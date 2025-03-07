param (
    [Parameter(Mandatory=$true)]
    [string]$Version,
    [switch]$UpdateAssemblyInfo = $true,
    [switch]$UpdatePackageVersion = $true
)

Write-Host "Updating version information to $Version..."

# Find all .csproj files
$projectFiles = Get-ChildItem -Path "./src" -Filter "*.csproj" -Recurse

if ($UpdatePackageVersion) {
    Write-Host "Updating package versions in .csproj files..."
    
    foreach ($projectFile in $projectFiles) {
        $content = Get-Content $projectFile.FullName -Raw
        
        # Update version elements if they exist
        if ($content -match "<Version>.*</Version>") {
            $content = $content -replace "<Version>.*</Version>", "<Version>$Version</Version>"
        } else {
            # Add version element if it doesn't exist
            $content = $content -replace "(<PropertyGroup>)", "`$1`n    <Version>$Version</Version>"
        }
        
        # Update package version elements if they exist
        if ($content -match "<PackageVersion>.*</PackageVersion>") {
            $content = $content -replace "<PackageVersion>.*</PackageVersion>", "<PackageVersion>$Version</PackageVersion>"
        }
        
        # Save the updated content
        Set-Content -Path $projectFile.FullName -Value $content
        
        Write-Host "Updated version in $($projectFile.FullName)"
    }
}

if ($UpdateAssemblyInfo) {
    Write-Host "Updating AssemblyInfo files..."
    
    # Find all AssemblyInfo.cs files
    $assemblyInfoFiles = Get-ChildItem -Path "./src" -Filter "AssemblyInfo.cs" -Recurse
    
    foreach ($file in $assemblyInfoFiles) {
        $content = Get-Content $file.FullName -Raw
        
        # Update assembly version attributes
        $content = $content -replace 'AssemblyVersion\("[^"]+"\)', "AssemblyVersion(`"$Version`")"
        $content = $content -replace 'AssemblyFileVersion\("[^"]+"\)', "AssemblyFileVersion(`"$Version`")"
        
        # Save the updated content
        Set-Content -Path $file.FullName -Value $content
        
        Write-Host "Updated version in $($file.FullName)"
    }
}

Write-Host "Version update completed successfully."
