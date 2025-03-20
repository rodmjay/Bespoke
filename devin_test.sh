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

# Check if Cypress is installed
if ! npm list --depth=0 -C "$APP_DIR" | grep -q "cypress"; then
    echo -e "${YELLOW}Installing Cypress...${NC}"
    cd "$APP_DIR" && npm install cypress --save-dev && npx cypress install
    echo -e "${GREEN}Cypress installed successfully.${NC}"
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
  
  # Ensure Cypress binary has correct permissions
  CYPRESS_BINARY=$(find ~/.cache -name "Cypress" -type f 2>/dev/null | head -1)
  if [ -n "$CYPRESS_BINARY" ]; then
    echo -e "${YELLOW}Setting permissions for Cypress binary...${NC}"
    chmod +x "$CYPRESS_BINARY"
  fi
  
  # Run Cypress tests
  npx cypress run
  
  if [ $? -eq 0 ]; then
    echo -e "${GREEN}Cypress tests completed successfully.${NC}"
    return 0
  else
    echo -e "${RED}Cypress tests failed.${NC}"
    return 1
  fi
}

# Main execution
main() {
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
