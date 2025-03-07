# Usage

Step 1: Install Nuget Package

`install-package TechValley.Handlebars`

Step 2: Register Dependencies with startup.cs

```
public void ConfigureServices(IServiceCollection services)
    {
        var builder = services.ConfigureApp(Configuration)
            .RegisterHandlebarsExtensions();      
    }
```

