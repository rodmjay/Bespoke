# SQLite Support for ResumePro

This project provides SQLite database support for the ResumePro application.

## Migration Commands

To create and apply SQLite migrations, follow these steps:

```bash
# Navigate to the API project directory
cd /home/ubuntu/projects/Bespoke/demo/ResumePro/ResumePro.Api

# Set the environment variable to use SQLite
# For Windows PowerShell:
$env:AppSettings__UseSQLite = "true"

# For Linux/macOS:
export AppSettings__UseSQLite=true

# Create initial migration
dotnet ef migrations add InitialMigration --project ../ResumePro.Infrastructure.SQLite --context ApplicationContext

# Apply migrations
dotnet ef database update --project ../ResumePro.Infrastructure.SQLite --context ApplicationContext
```

## Configuration

The SQLite database provider is configured in `appsettings.json`:

```json
{
  "AppSettings": {
    "UseSQLite": true
  },
  "ConnectionStrings": {
    "SQLiteConnection": "Data Source=ResumePro.db"
  }
}
```

Set `AppSettings:UseSQLite` to `true` to use SQLite or `false` to use SQL Server.
