

# Usage

Step 1: Install Nuget Package

`install-package Bespoke.Azure.AppInsights`

Step 2: Add AppInsightsSettings section to appsettings.json.

```
{
  "AppInsightsSettings": {
      "CloudRoleName": <Name Here>,
      "EnableAdaptiveSampling": true,
      "EnableDependencyTrackingTelemetryModule": true
  },
  "ConnectionStrings": {
    "ApplicationInsights":
      "Server=(localdb)\\mssqllocaldb;Database=<DatabaseName>;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
```

