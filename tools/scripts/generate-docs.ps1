param (
    [string]$OutputPath = "./docs/api",
    [switch]$OpenInBrowser = $false
)

Write-Host "Generating API documentation for Bespoke libraries..."

# Ensure output directory exists
if (-not (Test-Path $OutputPath)) {
    New-Item -ItemType Directory -Path $OutputPath -Force | Out-Null
}

# Projects to document
$projects = @(
    "./src/Bespoke.Core/Bespoke.Core.csproj",
    "./src/Bespoke.Logging/Bespoke.Logging.csproj",
    "./src/Bespoke.Messaging/Bespoke.Messaging.csproj"
)

# Check if DocFX is installed
$docfxInstalled = Get-Command docfx -ErrorAction SilentlyContinue
if (-not $docfxInstalled) {
    Write-Host "DocFX is not installed. Installing DocFX..."
    dotnet tool install -g docfx
}

# Generate DocFX configuration if it doesn't exist
$docfxConfigPath = "./docfx.json"
if (-not (Test-Path $docfxConfigPath)) {
    Write-Host "Creating DocFX configuration..."
    docfx init -q -o .
    
    # Update configuration to include our projects
    $docfxConfig = Get-Content $docfxConfigPath -Raw | ConvertFrom-Json
    $docfxConfig.metadata[0].src.files = "src/**.csproj"
    $docfxConfig.metadata[0].dest = "api"
    $docfxConfig.build.dest = $OutputPath
    
    $docfxConfig | ConvertTo-Json -Depth 10 | Set-Content $docfxConfigPath
}

# Build documentation
Write-Host "Building documentation..."
docfx $docfxConfigPath

if ($OpenInBrowser) {
    Write-Host "Opening documentation in browser..."
    Start-Process "$OutputPath/index.html"
}

Write-Host "Documentation generation completed successfully."
