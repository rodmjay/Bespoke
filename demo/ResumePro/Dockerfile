# Dockerfile at demo/IdentityPro/Dockerfile

# Build stage: use the .NET SDK image to restore, build, and publish the API project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /build

# Copy the entire repository (including demo and src folders) into the container.
# The build context is the repository root.
COPY . .

# Restore dependencies for the API project using its full path relative to the repo root.
RUN dotnet restore demo/ResumePro/ResumePro.Api/ResumePro.Api.csproj

# Set working directory to the API project folder
WORKDIR /build/demo/ResumePro/ResumePro.Api

# Publish the API project as a self-contained deployment for linux-x64.
RUN dotnet publish ResumePro.Api.csproj -c Release -o /app/publish \
    --self-contained true -r linux-x64 -p:PublishTrimmed=false

# Runtime stage: use the minimal runtime-deps image since the app is self-contained.
FROM mcr.microsoft.com/dotnet/runtime-deps:8.0
WORKDIR /app

# Copy the published output from the build stage.
COPY --from=build /app/publish .

# Expose the port your API listens on (adjust if needed)
EXPOSE 80

# Set the container’s entry point to the published API executable.
ENTRYPOINT ["./ResumePro.Api"]
