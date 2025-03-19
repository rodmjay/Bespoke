using System.Reflection;
using Bespoke.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ResumePro.Data.Contexts;
using Serilog;
using Serilog.Extensions.Logging;

namespace ResumePro.Infrastructure.PostgreSQL;

public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
{
    public ApplicationContext CreateDbContext(string[] args)
    {
        // Configure Serilog for design-time operations
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.Console()
            .CreateLogger();

        Log.Information("Initializing ApplicationContextFactory with explicit logging settings.");

        // Build configuration
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false)
            .AddJsonFile("appsettings.Development.json", optional: true)
            .AddEnvironmentVariables()
            .Build();

        // Create DbContext options
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
        
        // Get connection string from configuration
        var connectionString = configuration.GetConnectionString("PostgreSQLConnection");
        
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new InvalidOperationException("PostgreSQL connection string not found in configuration.");
        }

        // Configure PostgreSQL with migrations assembly
        optionsBuilder.UseNpgsql(connectionString, npgsqlOptions =>
        {
            npgsqlOptions.MigrationsAssembly("ResumePro.Infrastructure.PostgreSQL");
            npgsqlOptions.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
        });

        // Enable sensitive data logging in development
        optionsBuilder.EnableSensitiveDataLogging();
        
        // Create logger factory for DbContext
        var loggerFactory = new SerilogLoggerFactory(Log.Logger);
        optionsBuilder.UseLoggerFactory(loggerFactory);

        // Create DbSettings for ApplicationContext
        var dbSettings = new DbSettings
        {
            MigrationsAssembly = "ResumePro.Infrastructure.PostgreSQL",
            MaxRetryCount = 5,
            MaxRetryDelaySeconds = 10,
            Timeout = 30,
            ValidateSaves = true
        };
        
        var dbSettingsOptions = Options.Create(dbSettings);

        return new ApplicationContext(optionsBuilder.Options, dbSettingsOptions);
    }
}
