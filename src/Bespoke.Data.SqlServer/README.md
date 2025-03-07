# Bespoke.Data.SqlServer

This package provides SQL Server data access for the Bespoke framework.

## Features

- SQL Server-specific implementations of data access interfaces
- Entity Framework Core SQL Server provider integration
- Connection string management for SQL Server databases
- Migration utilities for SQL Server

## Getting Started

```csharp
// Example usage
var dbContext = new BespokeDbContext(sqlServerOptions);
var repository = new SqlServerRepository<Entity>(dbContext);
```

## Dependencies

- Bespoke.Data
- Microsoft.EntityFrameworkCore.SqlServer

## License

MIT
