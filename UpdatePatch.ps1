Param(
    [string]$Folder = "."
)

Get-ChildItem -Path $Folder -Recurse -Filter "*.csproj" | ForEach-Object {
    $file = $_.FullName
    Write-Host "Processing $file"

    $content = Get-Content $file -Raw
    if ($content -match "<Version>(\d+)\.(\d+)\.(\d+)</Version>") {
        $major = $Matches[1]
        $minor = $Matches[2]
        $patch = [int]$Matches[3]
        $newPatch = $patch + 1

        $oldVersion = "$major.$minor.$patch"
        $newVersion = "$major.$minor.$newPatch"

        $newContent = $content -replace "<Version>$oldVersion</Version>", "<Version>$newVersion</Version>"
        Set-Content -Path $file -Value $newContent

        Write-Host "Updated: $oldVersion -> $newVersion"
    }
    else {
        Write-Host "No version found in $file, skipping."
    }
}
