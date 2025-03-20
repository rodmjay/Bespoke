#!/bin/bash

# Colors for output
GREEN='\033[0;32m'
YELLOW='\033[1;33m'
RED='\033[0;31m'
NC='\033[0m' # No Color

echo -e "${YELLOW}ResumePro VM Setup Script${NC}"
echo -e "${YELLOW}==============================${NC}"

# Pull latest changes from main branch
echo -e "${YELLOW}Pulling latest changes from main branch...${NC}"
cd ~/repos/Bespoke
git pull 
echo -e "${GREEN}Repository updated successfully.${NC}"

# Update package lists
echo -e "${YELLOW}Updating package lists...${NC}"
sudo apt-get update
echo -e "${GREEN}Package lists updated successfully.${NC}"

# Install prerequisites
echo -e "${YELLOW}Installing prerequisites...${NC}"
sudo apt-get install -y curl apt-transport-https gnupg
echo -e "${GREEN}Prerequisites installed successfully.${NC}"

# Install Node.js
echo -e "${YELLOW}Installing Node.js...${NC}"
curl -fsSL https://deb.nodesource.com/setup_18.x | sudo -E bash -
sudo apt-get install -y nodejs
echo -e "${GREEN}Node.js installed successfully.${NC}"

# Install Angular CLI
echo -e "${YELLOW}Installing Angular CLI...${NC}"
sudo npm install -g @angular/cli
echo -e "${GREEN}Angular CLI installed successfully.${NC}"

# Install .NET SDK
echo -e "${YELLOW}Installing .NET SDK...${NC}"
wget https://packages.microsoft.com/config/ubuntu/$(lsb_release -rs)/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb
sudo apt-get update
sudo apt-get install -y dotnet-sdk-8.0
echo -e "${GREEN}.NET SDK installed successfully.${NC}"

# Install .NET EF Tools
echo -e "${YELLOW}Installing .NET Entity Framework Tools...${NC}"
dotnet tool install --global dotnet-ef
dotnet tool install --global dotnet-reportgenerator-globaltool
echo 'export PATH="$PATH:$HOME/.dotnet/tools"' >> ~/.bashrc
export PATH="$PATH:$HOME/.dotnet/tools"
echo -e "${GREEN}.NET Entity Framework Tools installed successfully.${NC}"

# Install PostgreSQL
echo -e "${YELLOW}Installing PostgreSQL...${NC}"
sudo apt-get install -y postgresql postgresql-contrib
sudo systemctl start postgresql
echo -e "${GREEN}PostgreSQL installed successfully.${NC}"

# Install Angular dependencies
echo -e "${YELLOW}Installing Angular dependencies...${NC}"
cd ~/repos/Bespoke/demo/ResumePro/ResumeProApp
npm install
echo -e "${GREEN}Angular dependencies installed successfully.${NC}"

# Install Cypress
echo -e "${YELLOW}Installing Cypress...${NC}"
cd ~/repos/Bespoke/demo/ResumePro/ResumeProApp
npm install cypress --save-dev
npx cypress install
echo -e "${GREEN}Cypress installed successfully.${NC}"

# Build Angular app
echo -e "${YELLOW}Building Angular app...${NC}"
cd ~/repos/Bespoke/demo/ResumePro/ResumeProApp
ng build --no-interactive
echo -e "${GREEN}Angular app built successfully.${NC}"

# Run the API
echo -e "${YELLOW}Starting the API...${NC}"
echo -e "${GREEN}To start the API, run:${NC}"
echo -e "dotnet run --project ~/repos/Bespoke/demo/ResumePro/ResumePro.Api/ResumePro.Api.csproj"

echo -e "${YELLOW}Setup completed successfully. Run devin_run.sh to set up the database and start the application.${NC}"
