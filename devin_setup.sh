#!/bin/bash
set -e  # Exit immediately if a command exits with a non-zero status

# Set non-interactive mode for apt-get and many CLI tools
export DEBIAN_FRONTEND=noninteractive
export CI=true

# Colors for output
GREEN='\033[0;32m'
YELLOW='\033[1;33m'
RED='\033[0;31m'
NC='\033[0m' # No Color

echo -e "${YELLOW}ResumePro VM Setup Script${NC}"
echo -e "${YELLOW}==============================${NC}"

# Update the repository if it exists
REPO_DIR=~/repos/Bespoke
if [ -d "$REPO_DIR" ]; then
  echo -e "${YELLOW}Pulling latest changes from main branch in ${REPO_DIR}...${NC}"
  cd "$REPO_DIR"
  git pull
  echo -e "${GREEN}Repository updated successfully.${NC}"
else
  echo -e "${RED}Repository directory ${REPO_DIR} does not exist. Skipping git pull.${NC}"
fi

# Update package lists
echo -e "${YELLOW}Updating package lists...${NC}"
sudo apt-get update
echo -e "${GREEN}Package lists updated successfully.${NC}"

# Install prerequisites
echo -e "${YELLOW}Installing prerequisites...${NC}"
sudo apt-get install -y curl apt-transport-https gnupg
echo -e "${GREEN}Prerequisites installed successfully.${NC}"

# Install Node.js if not already installed
if ! command -v node &> /dev/null; then
  echo -e "${YELLOW}Installing Node.js...${NC}"
  curl -fsSL https://deb.nodesource.com/setup_18.x | sudo -E bash -
  sudo apt-get install -y nodejs
  echo -e "${GREEN}Node.js installed successfully.${NC}"
else
  echo -e "${GREEN}Node.js is already installed. Skipping installation.${NC}"
fi

# Install Angular CLI if not already installed
if ! command -v ng &> /dev/null; then
  echo -e "${YELLOW}Installing Angular CLI...${NC}"
  sudo npm install -g @angular/cli
  echo -e "${GREEN}Angular CLI installed successfully.${NC}"
else
  echo -e "${GREEN}Angular CLI is already installed. Skipping installation.${NC}"
fi

# Install .NET SDK 8.0 if not already installed
if ! command -v dotnet &> /dev/null || ! dotnet --list-sdks | grep -q "8.0"; then
  echo -e "${YELLOW}Installing .NET SDK 8.0...${NC}"
  wget https://packages.microsoft.com/config/ubuntu/$(lsb_release -rs)/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
  sudo dpkg -i packages-microsoft-prod.deb
  rm packages-microsoft-prod.deb
  sudo apt-get update
  sudo apt-get install -y dotnet-sdk-8.0
  echo -e "${GREEN}.NET SDK installed successfully.${NC}"
else
  echo -e "${GREEN}.NET SDK 8.0 is already installed. Skipping installation.${NC}"
fi

# Install PostgreSQL if not already installed
if ! dpkg -l | grep -q postgresql; then
  echo -e "${YELLOW}Installing PostgreSQL...${NC}"
  sudo apt-get install -y postgresql postgresql-contrib
  sudo systemctl start postgresql
  echo -e "${GREEN}PostgreSQL installed and started successfully.${NC}"
else
  echo -e "${GREEN}PostgreSQL is already installed. Ensuring it is running...${NC}"
  sudo systemctl start postgresql
fi

# Install Angular dependencies if the Angular app directory exists
ANGULAR_APP_DIR=~/repos/Bespoke/demo/ResumePro/ResumeProApp
if [ -d "$ANGULAR_APP_DIR" ]; then
  echo -e "${YELLOW}Installing Angular dependencies...${NC}"
  cd "$ANGULAR_APP_DIR"
  npm install
  echo -e "${GREEN}Angular dependencies installed successfully.${NC}"
else
  echo -e "${RED}Angular app directory ${ANGULAR_APP_DIR} does not exist. Skipping npm install.${NC}"
fi

# Configure Angular CLI globally to be non-interactive and disable autocompletion prompt
echo -e "${YELLOW}Configuring Angular CLI to be non-interactive...${NC}"
ng config -g cli.interactive false --no-interactive
echo -e "${YELLOW}Disabling Angular CLI autocompletion prompt...${NC}"
ng config -g cli.autocomplete false --no-interactive

# Build Angular app with the non-interactive flag
echo -e "${YELLOW}Building Angular app...${NC}"
ng build --no-interactive
echo -e "${GREEN}Angular app built successfully.${NC}"

# Provide instruction to run the API
echo -e "${YELLOW}To start the API, run:${NC}"
echo -e "${GREEN}dotnet run --project ~/repos/Bespoke/demo/ResumePro.Api/ResumePro.Api.csproj${NC}"

echo -e "${YELLOW}Setup completed successfully. Run devin_run.sh to set up the database and start the application.${NC}"
