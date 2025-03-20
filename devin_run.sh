#!/bin/bash

# ResumePro Setup Script
# This script sets up the PostgreSQL database, runs migrations,
# starts the .NET API, and serves the Angular application.

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

if ! command -v psql &> /dev/null; then
    echo -e "${RED}PostgreSQL is not installed. Please install PostgreSQL and try again.${NC}"
    exit 1
fi

if ! command -v dotnet &> /dev/null; then
    echo -e "${RED}.NET SDK is not installed. Please install .NET SDK and try again.${NC}"
    exit 1
fi

if ! command -v npm &> /dev/null; then
    echo -e "${RED}Node.js is not installed. Please install Node.js and try again.${NC}"
    exit 1
fi

# Add .NET tools to PATH if not already there
if [[ ":$PATH:" != *":$HOME/.dotnet/tools:"* ]]; then
    echo -e "${YELLOW}Adding .NET tools to PATH...${NC}"
    export PATH="$PATH:$HOME/.dotnet/tools"
    echo 'export PATH="$PATH:$HOME/.dotnet/tools"' >> ~/.bashrc
fi

# Check for Entity Framework tools
if ! command -v dotnet-ef &> /dev/null; then
    echo -e "${YELLOW}Installing Entity Framework tools...${NC}"
    dotnet tool install --global dotnet-ef
fi

# Check for ReportGenerator
if ! command -v reportgenerator &> /dev/null; then
    echo -e "${YELLOW}Installing ReportGenerator...${NC}"
    dotnet tool install --global dotnet-reportgenerator-globaltool
fi

# Drop and recreate the database
echo -e "${YELLOW}Dropping and recreating the PostgreSQL database...${NC}"
sudo -u postgres psql -c "DROP DATABASE IF EXISTS $DB_NAME;" postgres
sudo -u postgres psql -c "CREATE DATABASE $DB_NAME;" postgres
sudo -u postgres psql -d $DB_NAME -c "CREATE EXTENSION IF NOT EXISTS citext;"
echo -e "${GREEN}Database recreated successfully.${NC}"

# Initialize the database with migrations
echo -e "${YELLOW}Initializing database with migrations...${NC}"
sudo -u postgres psql -d $DB_NAME -c "CREATE EXTENSION IF NOT EXISTS citext;"

# Create PostgreSQL user for the application
echo -e "${YELLOW}Creating PostgreSQL user for the application...${NC}"
DB_USER="resumepro_user"
# Generate a secure random password
DB_PASSWORD=$(openssl rand -base64 16)
echo -e "${YELLOW}Generated a secure random password for database user.${NC}"
# Store credentials in a secure file with restricted permissions
CREDENTIALS_FILE="$HOME/.resumepro_credentials"
echo "DB_USER=$DB_USER" > "$CREDENTIALS_FILE"
echo "DB_PASSWORD=$DB_PASSWORD" >> "$CREDENTIALS_FILE"
chmod 600 "$CREDENTIALS_FILE"
echo -e "${YELLOW}Database credentials stored in $CREDENTIALS_FILE${NC}"

sudo -u postgres psql -c "DROP ROLE IF EXISTS $DB_USER;"
sudo -u postgres psql -c "CREATE ROLE $DB_USER WITH LOGIN PASSWORD '$DB_PASSWORD';"
sudo -u postgres psql -c "GRANT ALL PRIVILEGES ON DATABASE $DB_NAME TO $DB_USER;"
sudo -u postgres psql -d $DB_NAME -c "GRANT ALL PRIVILEGES ON ALL TABLES IN SCHEMA public TO $DB_USER;"
sudo -u postgres psql -d $DB_NAME -c "GRANT ALL PRIVILEGES ON ALL SEQUENCES IN SCHEMA public TO $DB_USER;"
echo -e "${GREEN}PostgreSQL user created successfully.${NC}"

# Update API connection string
echo -e "${YELLOW}Updating API connection string...${NC}"
API_SETTINGS_FILE="$API_DIR/appsettings.json"
# Backup the original file
cp "$API_SETTINGS_FILE" "${API_SETTINGS_FILE}.bak"
# Update the connection string
sed -i "s|\"PostgreSQLConnection\": \".*\"|\"PostgreSQLConnection\": \"Host=localhost;Database=$DB_NAME;Username=$DB_USER;Password=$DB_PASSWORD\"|" "$API_SETTINGS_FILE"
echo -e "${GREEN}API connection string updated successfully.${NC}"

# Run migrations using Entity Framework CLI
echo -e "${YELLOW}Running database migrations...${NC}"
cd "$API_DIR" && \
dotnet add package Microsoft.EntityFrameworkCore.Design && \
dotnet-ef database update --project ../ResumePro.Infrastructure.PostgreSQL/ResumePro.Infrastructure.PostgreSQL.csproj --startup-project .
echo -e "${GREEN}Database migrations completed successfully.${NC}"

# Install NgRx packages for Angular app
echo -e "${YELLOW}Installing required Angular packages...${NC}"
cd "$APP_DIR" && npm install @ngrx/store @ngrx/effects @ngrx/store-devtools --save
echo -e "${GREEN}Angular packages installed successfully.${NC}"

# Check for Cypress and install if needed
echo -e "${YELLOW}Checking Cypress installation...${NC}"
if ! npm list --depth=0 | grep -q "cypress"; then
    echo -e "${YELLOW}Installing Cypress...${NC}"
    cd "$APP_DIR" && npm install cypress --save-dev && npx cypress install
    echo -e "${GREEN}Cypress installed successfully.${NC}"
fi

# Start the API and Angular app
echo -e "${YELLOW}Starting the API and Angular app...${NC}"
echo -e "${GREEN}To start the API, run:${NC}"
echo -e "cd $API_DIR && dotnet run"
echo -e "${GREEN}To start the Angular app, run:${NC}"
echo -e "cd $APP_DIR && npm run start"
echo -e "${GREEN}Access the application at http://localhost:4200${NC}"
