

# Usage

Step 1: Install Nuget Package

`install-package TechValley.Data`

Step 2: Add DbSettings section to appsettings.json.  Microservice supports a single database connection named
"SqlServer"

```
{
  "DbSettings": {
      "Timeout": 30,
      "MaxRetryCount": 5,
      "MaxRetryDelaySeconds": 20,
      "MaxBatchSize": 100,
      "SplitQueries": false,
      "UseContextPooling": false
  },
  "ConnectionStrings": {
    "SqlServer":
      "Server=(localdb)\\mssqllocaldb;Database=<DatabaseName>;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
```

