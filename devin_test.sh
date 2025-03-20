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
  npm start &
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
  
  # Check if ReportGenerator is installed
  if ! dotnet tool list -g | grep -q "dotnet-reportgenerator-globaltool"; then
    echo -e "${YELLOW}Installing ReportGenerator...${NC}"
    dotnet tool install -g dotnet-reportgenerator-globaltool
  fi
  
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
