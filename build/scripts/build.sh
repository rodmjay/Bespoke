#!/bin/bash

# Default parameters
CONFIGURATION="Release"
VERSION_SUFFIX=""
SKIP_TESTS=false

# Parse command line arguments
while [[ $# -gt 0 ]]; do
    key="$1"
    case $key in
        --configuration|-c)
        CONFIGURATION="$2"
        shift
        shift
        ;;
        --version-suffix|-v)
        VERSION_SUFFIX="$2"
        shift
        shift
        ;;
        --skip-tests|-s)
        SKIP_TESTS=true
        shift
        ;;
        *)
        echo "Unknown option: $1"
        exit 1
        ;;
    esac
done

echo "Building Bespoke solution..."
echo "Configuration: $CONFIGURATION"

# Build solution
dotnet build ./Bespoke.sln --configuration "$CONFIGURATION"

if [ "$SKIP_TESTS" = false ]; then
    echo "Running tests..."
    dotnet test ./Bespoke.sln --configuration "$CONFIGURATION" --no-build
fi

# Create NuGet packages
echo "Creating NuGet packages..."
PROJECTS=(
    "./src/Bespoke.Core/Bespoke.Core.csproj"
    "./src/Bespoke.Logging/Bespoke.Logging.csproj"
    "./src/Bespoke.Messaging/Bespoke.Messaging.csproj"
)

mkdir -p ./artifacts/packages

for PROJECT in "${PROJECTS[@]}"; do
    if [ -z "$VERSION_SUFFIX" ]; then
        dotnet pack "$PROJECT" --configuration "$CONFIGURATION" --no-build --output ./artifacts/packages
    else
        dotnet pack "$PROJECT" --configuration "$CONFIGURATION" --no-build --version-suffix "$VERSION_SUFFIX" --output ./artifacts/packages
    fi
done

echo "Build completed successfully."
