#!/bin/bash
set -e  # Exit immediately if a command exits with a non-zero status

# ResumePro Setup Script (Idempotent Version)
# This script sets up the PostgreSQL database, runs migrations,
# updates the API connection string, and prepares the Angular app.

# Configuration
API_DIR="$HOME/repos/Bespoke/demo/ResumePro/ResumePro.Api"
APP_DIR="$HOME/repos/Bespoke/demo/ResumePro/ResumeProApp"
DB_NAME="resumepro_test"

# Colors for output
GREEN='\033[0;32m'
RED='\033[0;31m'
YELLOW='\033[0;33m'
NC='\033[0m' # No Color

echo -e "${GREEN}ResumePro Setup Script${NC}"
echo "=============================="

# Check prerequisites
echo -e "${YELLOW}Checking prerequisites...${NC}"
for cmd in psql dotnet npm; do
    if ! command -v $cmd &> /dev/null; then
        echo -e "${RED}$cmd is not installed. Please install $cmd and try again.${NC}"
        exit 1
    fi
done

# Handle credentials file for DB user
CREDENTIALS_FILE="$HOME/.resumepro_credentials"
DB_USER="resumepro_user"
if [ -f "$CREDENTIALS_FILE" ]; then
    echo -e "${YELLOW}Using existing database credentials from $CREDENTIALS_FILE${NC}"
    source "$CREDENTIALS_FILE"
else
    echo -e "${YELLOW}Generating new secure random password for database user...${NC}"
    DB_PASSWORD=$(openssl rand -base64 16)
    echo "DB_USER=$DB_USER" > "$CREDENTIALS_FILE"
    echo "DB_PASSWORD=$DB_PASSWORD" >> "$CREDENTIALS_FILE"
    chmod 600 "$CREDENTIALS_FILE"
    echo -e "${GREEN}Database credentials stored in $CREDENTIALS_FILE${NC}"
fi

# Drop and recreate the database (this resets the DB state)
echo -e "${YELLOW}Dropping and recreating the PostgreSQL database '$DB_NAME'...${NC}"
sudo -u postgres psql -c "DROP DATABASE IF EXISTS $DB_NAME;" postgres
sudo -u postgres psql -c "CREATE DATABASE $DB_NAME;" postgres
sudo -u postgres psql -d $DB_NAME -c "CREATE EXTENSION IF NOT EXISTS citext;"
echo -e "${GREEN}Database recreated successfully.${NC}"

# Create PostgreSQL user for the application idempotently
echo -e "${YELLOW}Creating PostgreSQL user '$DB_USER' for the application...${NC}"
sudo -u postgres psql -c "DROP ROLE IF EXISTS $DB_USER;" postgres
sudo -u postgres psql -c "CREATE ROLE $DB_USER WITH LOGIN PASSWORD '$DB_PASSWORD';" postgres
sudo -u postgres psql -c "GRANT ALL PRIVILEGES ON DATABASE $DB_NAME TO $DB_USER;" postgres
sudo -u postgres psql -d $DB_NAME -c "GRANT ALL PRIVILEGES ON ALL TABLES IN SCHEMA public TO $DB_USER;"
sudo -u postgres psql -d $DB_NAME -c "GRANT ALL PRIVILEGES ON ALL SEQUENCES IN SCHEMA public TO $DB_USER;"
echo -e "${GREEN}PostgreSQL user created successfully.${NC}"

# Update API connection string in appsettings.json idempotently
echo -e "${YELLOW}Updating API connection string...${NC}"
API_SETTINGS_FILE="$API_DIR/appsettings.json"
if [ -f "$API_SETTINGS_FILE" ]; then
    # Backup original file if a backup doesn't already exist
    if [ ! -f "${API_SETTINGS_FILE}.bak" ]; then
        cp "$API_SETTINGS_FILE" "${API_SETTINGS_FILE}.bak"
    fi
    # Replace any current PostgreSQLConnection string with the desired one using a regex
    sed -i -E "s|\"PostgreSQLConnection\": \"[^\"]*\"|\"PostgreSQLConnection\": \"Host=localhost;Database=$DB_NAME;Username=$DB_USER;Password=$DB_PASSWORD\"|" "$API_SETTINGS_FILE"
    echo -e "${GREEN}API connection string updated successfully.${NC}"
else
    echo -e "${RED}API settings file not found at $API_SETTINGS_FILE. Skipping connection string update.${NC}"
fi

# Update IntegrationTests connection string in appsettings.json idempotently
echo -e "${YELLOW}Updating IntegrationTests connection string...${NC}"
INTEGRATION_TESTS_SETTINGS_FILE="$HOME/repos/Bespoke/demo/ResumePro/ResumePro.IntegrationTests/appsettings.json"
if [ -f "$INTEGRATION_TESTS_SETTINGS_FILE" ]; then
    # Backup original file if a backup doesn't already exist
    if [ ! -f "${INTEGRATION_TESTS_SETTINGS_FILE}.bak" ]; then
        cp "$INTEGRATION_TESTS_SETTINGS_FILE" "${INTEGRATION_TESTS_SETTINGS_FILE}.bak"
    fi
    # Replace any current PostgreSQLConnection string with the desired one using a regex
    sed -i -E "s|\"PostgreSQLConnection\": \"[^\"]*\"|\"PostgreSQLConnection\": \"Host=localhost;Database=$DB_NAME;Username=$DB_USER;Password=$DB_PASSWORD\"|" "$INTEGRATION_TESTS_SETTINGS_FILE"
    echo -e "${GREEN}IntegrationTests connection string updated successfully.${NC}"
else
    echo -e "${RED}IntegrationTests settings file not found at $INTEGRATION_TESTS_SETTINGS_FILE. Skipping connection string update.${NC}"
fi

# Run migrations using Entity Framework CLI
echo -e "${YELLOW}Running database migrations...${NC}"
cd "$API_DIR"
# Add the design package (this is idempotent if already added)
dotnet add package Microsoft.EntityFrameworkCore.Design

# Check if dotnet-ef is installed
if ! command -v dotnet-ef &> /dev/null; then
    echo -e "${YELLOW}Installing dotnet-ef tool...${NC}"
    dotnet tool install --global dotnet-ef
    # Source the profile to make the tool available in the current session
    source ~/.profile
fi

# Run the migration
dotnet ef database update --project ../ResumePro.Infrastructure.PostgreSQL/ResumePro.Infrastructure.PostgreSQL.csproj --startup-project .
echo -e "${GREEN}Database migrations completed successfully.${NC}"

# Install NgRx packages for the Angular app (npm install is idempotent)
echo -e "${YELLOW}Installing required Angular packages...${NC}"
cd "$APP_DIR"
npm install @ngrx/store @ngrx/effects @ngrx/store-devtools --save
echo -e "${GREEN}Angular packages installed successfully.${NC}"

# Instructions to start the API and Angular app
echo -e "${YELLOW}To start the API, run:${NC}"
echo -e "${GREEN}cd $API_DIR && dotnet run${NC}"
echo -e "${YELLOW}To start the Angular app, run:${NC}"
echo -e "${GREEN}cd $APP_DIR && npm run start${NC}"
echo -e "${GREEN}Access the application at http://localhost:4200${NC}"
