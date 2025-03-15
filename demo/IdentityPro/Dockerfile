# Build stage: use the .NET SDK image to restore and publish the project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the project file and restore dependencies
COPY IdentityPro.Idp/IdentityPro.Idp.csproj IdentityPro.Idp/
RUN dotnet restore IdentityPro.Idp/IdentityPro.Idp.csproj

# Copy the remaining source code
COPY . .

# Build and publish the project as a self-contained deployment (targeting linux-x64)
WORKDIR /src/IdentityPro.Idp
RUN dotnet publish IdentityPro.Idp.csproj -c Release -o /app/publish --self-contained true -r linux-x64 /p:PublishTrimmed=true

# Runtime stage: use the runtime-deps image which contains only the OS dependencies
FROM mcr.microsoft.com/dotnet/runtime-deps:8.0
WORKDIR /app

# Copy the published output from the build stage
COPY --from=build /app/publish .

# Expose the port (adjust if your API listens on a different port)
EXPOSE 80

# Run the application (assuming the output executable is named 'IdentityPro.Idp')
ENTRYPOINT ["./IdentityPro.Idp"]