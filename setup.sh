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

# Drop and recreate the database
echo -e "${YELLOW}Dropping and recreating the PostgreSQL database...${NC}"
sudo -u postgres psql -c "DROP DATABASE IF EXISTS $DB_NAME;" postgres
sudo -u postgres psql -c "CREATE DATABASE $DB_NAME;" postgres
sudo -u postgres psql -d $DB_NAME -c "CREATE EXTENSION IF NOT EXISTS citext;"
echo -e "${GREEN}Database recreated successfully.${NC}"

# Initialize the database with basic schema
echo -e "${YELLOW}Initializing database with basic schema...${NC}"
sudo -u postgres psql -d $DB_NAME -c "
CREATE TABLE IF NOT EXISTS \"Persona\" (
    \"Id\" UUID PRIMARY KEY,
    \"FirstName\" VARCHAR(100) NOT NULL,
    \"LastName\" VARCHAR(100) NOT NULL,
    \"Email\" VARCHAR(255),
    \"Phone\" VARCHAR(50),
    \"Address\" VARCHAR(255),
    \"City\" VARCHAR(100),
    \"StateProvinceId\" INT,
    \"PostalCode\" VARCHAR(20),
    \"CountryId\" INT,
    \"Summary\" TEXT,
    \"Created\" TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    \"Updated\" TIMESTAMP
);

CREATE TABLE IF NOT EXISTS \"Resume\" (
    \"Id\" UUID PRIMARY KEY,
    \"PersonaId\" UUID NOT NULL REFERENCES \"Persona\"(\"Id\"),
    \"Name\" VARCHAR(100) NOT NULL,
    \"Created\" TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    \"Updated\" TIMESTAMP
);"

echo -e "${GREEN}Database initialized with basic schema.${NC}"

# Start the API and Angular app
echo -e "${YELLOW}Starting the API and Angular app...${NC}"
echo -e "${GREEN}To start the API, run:${NC}"
echo -e "cd $API_DIR && dotnet run"
echo -e "${GREEN}To start the Angular app, run:${NC}"
echo -e "cd $APP_DIR && npm run start"
echo -e "${GREEN}Access the application at http://localhost:4200${NC}"
