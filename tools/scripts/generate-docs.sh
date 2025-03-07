#!/bin/bash

# Default parameters
OUTPUT_PATH="./docs/api"
OPEN_IN_BROWSER=false

# Parse command line arguments
while [[ $# -gt 0 ]]; do
    key="$1"
    case $key in
        --output|-o)
        OUTPUT_PATH="$2"
        shift
        shift
        ;;
        --open-browser|-b)
        OPEN_IN_BROWSER=true
        shift
        ;;
        *)
        echo "Unknown option: $1"
        exit 1
        ;;
    esac
done

echo "Generating API documentation for Bespoke libraries..."

# Ensure output directory exists
mkdir -p "$OUTPUT_PATH"

# Projects to document
PROJECTS=(
    "./src/Bespoke.Core/Bespoke.Core.csproj"
    "./src/Bespoke.Logging/Bespoke.Logging.csproj"
    "./src/Bespoke.Messaging/Bespoke.Messaging.csproj"
)

# Check if DocFX is installed
if ! command -v docfx &> /dev/null; then
    echo "DocFX is not installed. Installing DocFX..."
    dotnet tool install -g docfx
fi

# Generate DocFX configuration if it doesn't exist
DOCFX_CONFIG="./docfx.json"
if [ ! -f "$DOCFX_CONFIG" ]; then
    echo "Creating DocFX configuration..."
    docfx init -q -o .
    
    # Update configuration to include our projects (simplified for shell script)
    sed -i 's/"src\/\*\*\/\*.csproj"/"src\/\*\*\/\*.csproj"/g' "$DOCFX_CONFIG"
    sed -i 's/"obj\/api"/"api"/g' "$DOCFX_CONFIG"
    sed -i "s/\"_site\"/\"$OUTPUT_PATH\"/g" "$DOCFX_CONFIG"
fi

# Build documentation
echo "Building documentation..."
docfx "$DOCFX_CONFIG"

if [ "$OPEN_IN_BROWSER" = true ]; then
    echo "Opening documentation in browser..."
    if command -v xdg-open &> /dev/null; then
        xdg-open "$OUTPUT_PATH/index.html"
    elif command -v open &> /dev/null; then
        open "$OUTPUT_PATH/index.html"
    else
        echo "Could not open browser automatically. Please open $OUTPUT_PATH/index.html manually."
    fi
fi

echo "Documentation generation completed successfully."
