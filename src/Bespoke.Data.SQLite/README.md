# Bespoke.Data.SQLite

This library provides SQLite database support for the Bespoke framework.

## Features

- SQLite database provider integration
- Compatible with Bespoke's data builder pattern
- Supports Entity Framework Core migrations

## Usage

```csharp
services.AddBespoke(Configuration, builder =>
{
    builder.AddStorage(
        dbSettings => 
        {
            dbSettings.MigrationsAssembly = "YourProject.Infrastructure.SQLite";
        },
        dataBuilder => 
        {
            dataBuilder.UseSQLite<YourDbContext>(sqliteSettings =>
            {
                sqliteSettings.ConnectionStringName = "SQLiteConnection";
            });
        }
    );
});
```

## Configuration

Add SQLite connection string to your appsettings.json:

```json
{
  "ConnectionStrings": {
    "SQLiteConnection": "Data Source=YourDatabase.db"
  },
  "DbSettings": {
    "SQLite": {
      "ConnectionStringName": "SQLiteConnection"
    }
  }
}
```
