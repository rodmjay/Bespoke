#############################################
# Stage 1: Build the Angular app with Node 18
#############################################
FROM node:18 AS node-build
WORKDIR /app/ResumeProApp
# Copy Angular project files from repository root (located in demo/ResumePro/ResumeProApp)
COPY demo/ResumePro/ResumeProApp/ ./
# (Optional) List files for debugging � remove when confirmed
RUN ls -la
# Remove any existing node_modules (to avoid platform conflicts)
RUN rm -rf node_modules
# Install dependencies and build the Angular app using production configuration
RUN npm install && \
    # Create a complete Angular workspace configuration file with all required properties
    echo '{' > angular.json && \
    echo '  "$schema": "./node_modules/@angular/cli/lib/config/schema.json",' >> angular.json && \
    echo '  "version": 1,' >> angular.json && \
    echo '  "newProjectRoot": "projects",' >> angular.json && \
    echo '  "projects": {' >> angular.json && \
    echo '    "resumepro": {' >> angular.json && \
    echo '      "projectType": "application",' >> angular.json && \
    echo '      "root": "",' >> angular.json && \
    echo '      "sourceRoot": "src",' >> angular.json && \
    echo '      "prefix": "app",' >> angular.json && \
    echo '      "architect": {' >> angular.json && \
    echo '        "build": {' >> angular.json && \
    echo '          "builder": "@angular-devkit/build-angular:application",' >> angular.json && \
    echo '          "options": {' >> angular.json && \
    echo '            "outputPath": "dist/resumepro",' >> angular.json && \
    echo '            "index": "src/index.html",' >> angular.json && \
    echo '            "browser": "src/main.ts",' >> angular.json && \
    echo '            "polyfills": ["zone.js"],' >> angular.json && \
    echo '            "tsConfig": "tsconfig.app.json",' >> angular.json && \
    echo '            "inlineStyleLanguage": "scss",' >> angular.json && \
    echo '            "assets": ["src/assets"],' >> angular.json && \
    echo '            "styles": ["src/styles.scss"],' >> angular.json && \
    echo '            "scripts": []' >> angular.json && \
    echo '          }' >> angular.json && \
    echo '        }' >> angular.json && \
    echo '      }' >> angular.json && \
    echo '    }' >> angular.json && \
    echo '  }' >> angular.json && \
    echo '}' >> angular.json && \
    # Build the Angular app using the production configuration
    npm run build --configuration=production

##################################################
# Stage 2: Build and publish the .NET API with SDK
##################################################
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /build
# Copy the entire repository (build context is the repository root)
COPY . .
# Set working directory to the API project folder (adjust path if necessary)
WORKDIR /build/demo/ResumePro/ResumePro.Api
# Restore dependencies (disabling treat warnings as errors)
RUN dotnet restore ResumePro.Api.csproj /p:TreatWarningsAsErrors=false
# Publish the API as a self-contained deployment for linux-x64
RUN dotnet publish ResumePro.Api.csproj -c Release -o /app/publish \
    --self-contained true -r linux-x64 -p:PublishTrimmed=false /p:TreatWarningsAsErrors=false

#####################################################
# Stage 3: Create final runtime image using runtime-deps
#####################################################
FROM mcr.microsoft.com/dotnet/runtime-deps:8.0
WORKDIR /app
# Copy the published API output from the build stage
COPY --from=build /app/publish .
# Copy the Angular build output into wwwroot so that the API can serve the static files.
# (This assumes Angular outputs to "dist/resumepro" � adjust if necessary.)
COPY --from=node-build /app/ResumeProApp/dist/resumepro ./wwwroot
# Expose the API port (adjust if necessary)
EXPOSE 80
# Set the container�s entry point to the published API executable
ENTRYPOINT ["./ResumePro.Api"]
