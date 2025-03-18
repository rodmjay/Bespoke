# ResumePro

ResumePro is a comprehensive resume management application that allows users to create, manage, and export professional resumes. The application consists of a .NET API backend and an Angular frontend.

## Prerequisites

- .NET SDK 8.0
- Node.js 18+ and npm
- Angular CLI (`npm install -g @angular/cli`)

## Project Structure

- `ResumePro.Api`: Backend API built with .NET 8.0
- `ResumeProApp`: Frontend application built with Angular 19
- `ResumePro.IntegrationTests`: Integration tests for the API
- Other supporting projects for domain, data, services, etc.

## Getting Started with the API

### Building the API

```bash
cd ~/repos/Bespoke/demo/ResumePro/ResumePro.Api
dotnet build
```

### Running the API

```bash
cd ~/repos/Bespoke/demo/ResumePro/ResumePro.Api
dotnet run
```

By default, the API will be available at `https://localhost:5001` and `http://localhost:5000`.

## Getting Started with the Angular App

### Installing Dependencies

```bash
cd ~/repos/Bespoke/demo/ResumePro/ResumeProApp
npm install
```

### Building the Angular App

```bash
cd ~/repos/Bespoke/demo/ResumePro/ResumeProApp
npm run build
```

This will create a production build in the `dist/resumepro` directory.

### Running the Angular App for Development

```bash
cd ~/repos/Bespoke/demo/ResumePro/ResumeProApp
npm start
```

The application will be available at `http://localhost:4200`.

## Running Tests

### Running Cypress Tests (Frontend)

Cypress tests are used for end-to-end testing of the Angular application.

#### Interactive Mode

```bash
cd ~/repos/Bespoke/demo/ResumePro/ResumeProApp
npx cypress open
```

This will open the Cypress Test Runner, where you can select and run tests interactively.

#### Headless Mode

```bash
cd ~/repos/Bespoke/demo/ResumePro/ResumeProApp
npx cypress run
```

This will run all Cypress tests in headless mode and output the results to the console.

### Running Integration Tests (Backend)

Integration tests are used to test the API controllers and their interactions with the database.

#### Running All Tests

```bash
cd ~/repos/Bespoke/demo/ResumePro/ResumePro.IntegrationTests
dotnet test
```

#### Running Specific Tests

```bash
cd ~/repos/Bespoke/demo/ResumePro/ResumePro.IntegrationTests
dotnet test --filter "FullyQualifiedName~ResumePro.IntegrationTests.Tests.Controllers.ControllerNameTests"
```

#### Generating Code Coverage Report

```bash
cd ~/repos/Bespoke/demo/ResumePro/ResumePro.IntegrationTests
./run-coverage.sh
```

The coverage report will be available at `./CoverageReport/index.html`.

## Docker Support

The project includes a Dockerfile for containerization. To build and run the Docker container:

```bash
cd ~/repos/Bespoke
docker build -t resumepro -f demo/ResumePro/Dockerfile .
docker run -p 80:80 resumepro
```

## Making a Pull Request to GitHub

1. Create a new branch for your changes:
   ```bash
   git checkout -b feature/your-feature-name
   ```

2. Make your changes and commit them:
   ```bash
   git add .
   git commit -m "Description of your changes"
   ```

3. Push your branch to GitHub:
   ```bash
   git push -u origin feature/your-feature-name
   ```

4. Create a pull request using the GitHub CLI:
   ```bash
   gh pr create --title "Your PR title" --body "Description of your changes"
   ```

5. Squash commits when merging:
   All pull requests should have commits squashed into a single commit before merging to maintain a clean git history.

## Troubleshooting

### API Issues
- Ensure the database connection string is correctly configured
- Check that the required dependencies are installed
- Verify that the correct .NET SDK version is installed

### Angular App Issues
- Clear the npm cache: `npm cache clean --force`
- Delete the node_modules directory and reinstall: `rm -rf node_modules && npm install`
- Ensure you're using a compatible Node.js version
