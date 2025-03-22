# Auto-elevate if not running as Administrator
if (-not ([Security.Principal.WindowsPrincipal] [Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole] "Administrator"))
{
    Write-Host "Not running as Administrator. Restarting with elevated rights..."
    $arguments = "-NoProfile -ExecutionPolicy Bypass -File `"$PSCommandPath`""
    Start-Process powershell -Verb RunAs -ArgumentList $arguments
    exit
}

# Idempotent PostgreSQL installation and user creation script

# 1. Check if PostgreSQL is installed via Chocolatey
$pgInstalled = choco list --local-only postgresql | Select-String "postgresql"
if (-not $pgInstalled) {
    Write-Host "PostgreSQL is not installed. Installing via Chocolatey..."
    # --no-progress suppresses interactive progress output.
    choco install postgresql -y --no-progress
} else {
    Write-Host "PostgreSQL is already installed."
}

# 2. Wait a bit for PostgreSQL service to start (adjust if needed)
Write-Host "Waiting for PostgreSQL service to start..."
Start-Sleep -Seconds 10

# 3. (Optional) Set the PGPASSWORD environment variable if your postgres superuser requires a password.
# $env:PGPASSWORD = "YourPostgresSuperuserPassword"

# 4. Define SQL to create the dev_user if it doesn't exist.
$sql = @"
DO \$\$
BEGIN
    IF NOT EXISTS (
        SELECT FROM pg_catalog.pg_roles WHERE rolname = 'dev_user'
    ) THEN
        CREATE ROLE dev_user LOGIN PASSWORD 'Pa$$word!';
    END IF;
END
\$\$;
"@

Write-Host "Creating role 'dev_user' if it does not already exist..."
# Execute the SQL command using psql. This assumes the 'postgres' superuser can log in without an interactive password.
psql -U postgres -d postgres -c "$sql"

Write-Host "Script complete."
