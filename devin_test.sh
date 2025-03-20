#!/bin/bash

# ResumePro Test Script
# This script runs both integration tests and Cypress tests for the ResumePro application

# Colors for output
GREEN='\033[0;32m'
RED='\033[0;31m'
YELLOW='\033[0;33m'
NC='\033[0m' # No Color

echo -e "${GREEN}ResumePro Test Script${NC}"
echo "=============================="

# Configuration
API_DIR="$HOME/repos/Bespoke/demo/ResumePro/ResumePro.Api"
APP_DIR="$HOME/repos/Bespoke/demo/ResumePro/ResumeProApp"
INTEGRATION_TESTS_DIR="$HOME/repos/Bespoke/demo/ResumePro/ResumePro.IntegrationTests"
COVERAGE_REPORT_DIR="$INTEGRATION_TESTS_DIR/CoverageReport"

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

# Check if credentials file exists and update appsettings.json if needed
CREDENTIALS_FILE="$HOME/.resumepro_credentials"
if [ -f "$CREDENTIALS_FILE" ]; then
  echo -e "${YELLOW}Found credentials file. Updating appsettings.json...${NC}"
  source "$CREDENTIALS_FILE"
  API_SETTINGS_FILE="$API_DIR/appsettings.json"
  # Backup the original file if not already backed up
  if [ ! -f "${API_SETTINGS_FILE}.bak" ]; then
    cp "$API_SETTINGS_FILE" "${API_SETTINGS_FILE}.bak"
  fi
  # Update the connection string
  sed -i "s|\"PostgreSQLConnection\": \".*\"|\"PostgreSQLConnection\": \"Host=localhost;Database=resumepro_test;Username=$DB_USER;Password=$DB_PASSWORD\"|" "$API_SETTINGS_FILE"
  echo -e "${GREEN}API connection string updated successfully.${NC}"
else
  echo -e "${YELLOW}No credentials file found. Running devin_run.sh first...${NC}"
  $HOME/repos/Bespoke/devin_run.sh
fi

# Check if Cypress is installed and install/update dependencies
echo -e "${YELLOW}Checking Cypress installation...${NC}"
cd "$APP_DIR"

# Install Cypress dependencies for Ubuntu
if [ "$(grep -i ubuntu /etc/os-release)" != "" ]; then
  echo -e "${YELLOW}Installing Cypress dependencies for Ubuntu...${NC}"
  sudo apt-get update && sudo apt-get install -y libgtk2.0-0 libgtk-3-0 libgbm-dev libnotify-dev \
  libgconf-2-4 libnss3 libxss1 libasound2 libxtst6 xauth xvfb
fi

# Ensure Cypress is properly installed with the correct version
echo -e "${YELLOW}Installing Cypress v12.17.4...${NC}"
npm uninstall cypress
npm install cypress@12.17.4 --save-dev

# Create local Cypress cache folder
mkdir -p "$APP_DIR/.cypress-cache"
export CYPRESS_CACHE_FOLDER="$APP_DIR/.cypress-cache"
export CYPRESS_INSTALL_BINARY=12.17.4

# Force reinstall Cypress
echo -e "${YELLOW}Force reinstalling Cypress binary...${NC}"
npx cypress install --force
echo -e "${GREEN}Cypress installed successfully.${NC}"

# Verify Cypress binary exists
CYPRESS_BINARY=$(find "$APP_DIR/.cypress-cache" -name "Cypress" -type f 2>/dev/null | head -1)
if [ -n "$CYPRESS_BINARY" ]; then
  echo -e "${YELLOW}Setting permissions for Cypress binary...${NC}"
  chmod +x "$CYPRESS_BINARY"
  CYPRESS_BINARY_DIR=$(dirname "$CYPRESS_BINARY")
  find "$CYPRESS_BINARY_DIR" -type f -exec chmod +x {} \;
else
  echo -e "${RED}Cypress binary not found. Installing globally...${NC}"
  CYPRESS_CACHE_FOLDER="$APP_DIR/.cypress-cache" npm install -g cypress@12.17.4
  CYPRESS_CACHE_FOLDER="$APP_DIR/.cypress-cache" npx cypress install --force
fi

# Check if API and Angular app are running
check_api_running() {
  echo -e "${YELLOW}Checking if API is running...${NC}"
  if curl -s http://localhost:5229/health | grep -q "Healthy"; then
    echo -e "${GREEN}API is running.${NC}"
    return 0
  else
    echo -e "${RED}API is not running.${NC}"
    return 1
  fi
}

check_angular_running() {
  echo -e "${YELLOW}Checking if Angular app is running...${NC}"
  if curl -s http://localhost:4200 | grep -q "ResumePro"; then
    echo -e "${GREEN}Angular app is running.${NC}"
    return 0
  else
    echo -e "${RED}Angular app is not running.${NC}"
    return 1
  fi
}

# Start API if not running
start_api() {
  echo -e "${YELLOW}Starting API...${NC}"
  cd "$API_DIR" || exit 1
  dotnet run &
  API_PID=$!
  echo -e "${GREEN}API started with PID: $API_PID${NC}"
  
  # Wait for API to be ready
  echo -e "${YELLOW}Waiting for API to be ready...${NC}"
  for i in {1..30}; do
    if curl -s http://localhost:5229/health | grep -q "Healthy"; then
      echo -e "${GREEN}API is ready.${NC}"
      return 0
    fi
    echo -n "."
    sleep 2
  done
  
  echo -e "${RED}API failed to start within the timeout period.${NC}"
  return 1
}

# Start Angular app if not running
start_angular() {
  echo -e "${YELLOW}Starting Angular app...${NC}"
  cd "$APP_DIR" || exit 1
  npm start -- --no-interactive &
  ANGULAR_PID=$!
  echo -e "${GREEN}Angular app started with PID: $ANGULAR_PID${NC}"
  
  # Wait for Angular app to be ready
  echo -e "${YELLOW}Waiting for Angular app to be ready...${NC}"
  for i in {1..30}; do
    if curl -s http://localhost:4200 | grep -q "ResumePro"; then
      echo -e "${GREEN}Angular app is ready.${NC}"
      return 0
    fi
    echo -n "."
    sleep 2
  done
  
  echo -e "${RED}Angular app failed to start within the timeout period.${NC}"
  return 1
}

# Run integration tests
run_integration_tests() {
  echo -e "${YELLOW}Running integration tests with coverage...${NC}"
  cd "$INTEGRATION_TESTS_DIR" || exit 1
  
  # Run tests with coverage
  dotnet test --collect:"XPlat Code Coverage"
  
  # Find the coverage file
  COVERAGE_FILE=$(find . -name "coverage.cobertura.xml" | head -1)
  
  if [ -n "$COVERAGE_FILE" ]; then
    # Generate the report
    echo -e "${YELLOW}Generating coverage report...${NC}"
    reportgenerator "-reports:$COVERAGE_FILE" "-targetdir:$COVERAGE_REPORT_DIR" -reporttypes:Html
    
    echo -e "${GREEN}Integration tests completed. Coverage report available at: $COVERAGE_REPORT_DIR/index.html${NC}"
  else
    echo -e "${RED}No coverage file found. Tests may have failed.${NC}"
    return 1
  fi
  
  return 0
}

# Run Cypress tests
run_cypress_tests() {
  echo -e "${YELLOW}Running Cypress tests...${NC}"
  cd "$APP_DIR" || exit 1
  
  # Ensure Cypress is properly installed
  echo -e "${YELLOW}Ensuring Cypress is properly installed...${NC}"
  npm uninstall cypress
  npm install cypress@12.17.4 --save-dev
  
  # Create a local Cypress cache folder and install Cypress there
  mkdir -p "$APP_DIR/.cypress-cache"
  
  # Install Cypress directly using npm
  echo -e "${YELLOW}Installing Cypress globally...${NC}"
  npm install -g cypress@12.17.4
  
  # Try to find the Cypress binary
  CYPRESS_BINARY=$(which cypress 2>/dev/null)
  if [ -z "$CYPRESS_BINARY" ]; then
    CYPRESS_BINARY=$(find /usr/local/bin -name "cypress" 2>/dev/null | head -1)
  fi
  
  if [ -n "$CYPRESS_BINARY" ]; then
    echo -e "${GREEN}Found Cypress binary at: $CYPRESS_BINARY${NC}"
  else
    echo -e "${RED}Cypress binary not found. Using npx...${NC}"
    CYPRESS_BINARY="npx cypress"
  fi
  
  # Clean Cypress cache if needed
  echo -e "${YELLOW}Clearing Cypress cache...${NC}"
  npx cypress cache clear
  
  # Run Cypress tests with better error handling
  echo -e "${YELLOW}Running Cypress tests with headless Electron...${NC}"
  cd "$APP_DIR" && CYPRESS_CACHE_FOLDER="$HOME/.cache/Cypress" CYPRESS_CRASH_REPORTS=0 ELECTRON_ENABLE_LOGGING=1 $CYPRESS_BINARY run --browser electron --project "$APP_DIR"
  
  if [ $? -eq 0 ]; then
    echo -e "${GREEN}Cypress tests completed successfully.${NC}"
    return 0
  else
    echo -e "${RED}Cypress tests failed. Trying with more diagnostic information...${NC}"
    cd "$APP_DIR" && CYPRESS_CACHE_FOLDER="$HOME/.cache/Cypress" CYPRESS_CRASH_REPORTS=0 DEBUG=cypress:* npx cypress run --browser electron --project "$APP_DIR"
    
    if [ $? -eq 0 ]; then
      echo -e "${GREEN}Cypress tests completed successfully on retry.${NC}"
      return 0
    else
      echo -e "${RED}Cypress tests failed after retry.${NC}"
      return 1
    fi
  fi
}

# Setup database
setup_database() {
  echo -e "${YELLOW}Setting up database...${NC}"
  
  # Check if PostgreSQL is running
  if ! pg_isready -h localhost -p 5432 > /dev/null 2>&1; then
    echo -e "${RED}PostgreSQL is not running. Starting PostgreSQL...${NC}"
    sudo service postgresql start
    sleep 2
  fi
  
  # Create database and user if they don't exist
  echo -e "${YELLOW}Ensuring database and user exist...${NC}"
  sudo -u postgres psql -c "SELECT 1 FROM pg_database WHERE datname = 'resumepro_test'" | grep -q 1 || sudo -u postgres psql -c "CREATE DATABASE resumepro_test;"
  sudo -u postgres psql -c "SELECT 1 FROM pg_roles WHERE rolname = 'resumepro_user'" | grep -q 1 || sudo -u postgres psql -c "CREATE USER resumepro_user WITH PASSWORD '/vNm1VBGD2Es93GrZX33yg==';"
  sudo -u postgres psql -c "GRANT ALL PRIVILEGES ON DATABASE resumepro_test TO resumepro_user;"
  
  # Apply migrations
  echo -e "${YELLOW}Applying database migrations...${NC}"
  cd "$API_DIR" || exit 1
  dotnet ef database update || echo -e "${RED}Failed to apply migrations. Continuing anyway...${NC}"
}

# Main execution
main() {
  # Setup database first
  setup_database
  
  # Check if API is running, start if not
  if ! check_api_running; then
    start_api
  fi
  
  # Check if Angular app is running, start if not
  if ! check_angular_running; then
    start_angular
  fi
  
  # Run integration tests
  run_integration_tests
  INTEGRATION_TESTS_RESULT=$?
  
  # Run Cypress tests
  run_cypress_tests
  CYPRESS_TESTS_RESULT=$?
  
  # Print summary
  echo -e "${GREEN}Test Summary:${NC}"
  echo "=============================="
  if [ $INTEGRATION_TESTS_RESULT -eq 0 ]; then
    echo -e "${GREEN}Integration Tests: PASSED${NC}"
  else
    echo -e "${RED}Integration Tests: FAILED${NC}"
  fi
  
  if [ $CYPRESS_TESTS_RESULT -eq 0 ]; then
    echo -e "${GREEN}Cypress Tests: PASSED${NC}"
  else
    echo -e "${RED}Cypress Tests: FAILED${NC}"
  fi
  
  # Return overall result
  if [ $INTEGRATION_TESTS_RESULT -eq 0 ] && [ $CYPRESS_TESTS_RESULT -eq 0 ]; then
    echo -e "${GREEN}All tests passed!${NC}"
    return 0
  else
    echo -e "${RED}Some tests failed. See above for details.${NC}"
    return 1
  fi
}

# Run the main function
main
