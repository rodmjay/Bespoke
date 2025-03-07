param (
    [string]$Configuration = "Release",
    [string]$VersionSuffix = "",
    [switch]$SkipTests = $false
)

Write-Host "Building Bespoke solution..."
Write-Host "Configuration: $Configuration"

# Build solution
dotnet build ./Bespoke.sln --configuration $Configuration

if (-not $SkipTests) {
    Write-Host "Running tests..."
    dotnet test ./Bespoke.sln --configuration $Configuration --no-build
}

# Create NuGet packages
Write-Host "Creating NuGet packages..."
$projects = @(
    "./src/Bespoke.Core/Bespoke.Core.csproj",
    "./src/Bespoke.Logging/Bespoke.Logging.csproj",
    "./src/Bespoke.Messaging/Bespoke.Messaging.csproj"
)

foreach ($project in $projects) {
    if ([string]::IsNullOrEmpty($VersionSuffix)) {
        dotnet pack $project --configuration $Configuration --no-build --output ./artifacts/packages
    } else {
        dotnet pack $project --configuration $Configuration --no-build --version-suffix $VersionSuffix --output ./artifacts/packages
    }
}

Write-Host "Build completed successfully."
