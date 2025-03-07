#!/bin/bash

# Default parameters
VERSION=""
UPDATE_ASSEMBLY_INFO=true
UPDATE_PACKAGE_VERSION=true

# Parse command line arguments
while [[ $# -gt 0 ]]; do
    key="$1"
    case $key in
        --version|-v)
        VERSION="$2"
        shift
        shift
        ;;
        --skip-assembly-info)
        UPDATE_ASSEMBLY_INFO=false
        shift
        ;;
        --skip-package-version)
        UPDATE_PACKAGE_VERSION=false
        shift
        ;;
        *)
        echo "Unknown option: $1"
        exit 1
        ;;
    esac
done

if [ -z "$VERSION" ]; then
    echo "Error: Version parameter is required. Use --version or -v to specify a version."
    exit 1
fi

echo "Updating version information to $VERSION..."

if [ "$UPDATE_PACKAGE_VERSION" = true ]; then
    echo "Updating package versions in .csproj files..."
    
    # Find all .csproj files
    find ./src -name "*.csproj" -type f | while read -r PROJECT_FILE; do
        echo "Processing $PROJECT_FILE"
        
        # Check if Version element exists
        if grep -q "<Version>" "$PROJECT_FILE"; then
            # Update existing Version element
            sed -i "s|<Version>.*</Version>|<Version>$VERSION</Version>|g" "$PROJECT_FILE"
        else
            # Add Version element after first PropertyGroup opening tag
            sed -i "s|<PropertyGroup>|<PropertyGroup>\n    <Version>$VERSION</Version>|" "$PROJECT_FILE"
        fi
        
        # Check if PackageVersion element exists
        if grep -q "<PackageVersion>" "$PROJECT_FILE"; then
            # Update existing PackageVersion element
            sed -i "s|<PackageVersion>.*</PackageVersion>|<PackageVersion>$VERSION</PackageVersion>|g" "$PROJECT_FILE"
        fi
        
        echo "Updated version in $PROJECT_FILE"
    done
fi

if [ "$UPDATE_ASSEMBLY_INFO" = true ]; then
    echo "Updating AssemblyInfo files..."
    
    # Find all AssemblyInfo.cs files
    find ./src -name "AssemblyInfo.cs" -type f | while read -r ASSEMBLY_FILE; do
        echo "Processing $ASSEMBLY_FILE"
        
        # Update assembly version attributes
        sed -i "s|AssemblyVersion(\"[^\"]*\")|AssemblyVersion(\"$VERSION\")|g" "$ASSEMBLY_FILE"
        sed -i "s|AssemblyFileVersion(\"[^\"]*\")|AssemblyFileVersion(\"$VERSION\")|g" "$ASSEMBLY_FILE"
        
        echo "Updated version in $ASSEMBLY_FILE"
    done
fi

echo "Version update completed successfully."
