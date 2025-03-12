﻿using Bespoke.Data;
using IdentityPro.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using Serilog;
using Serilog.Events;

namespace IdentityPro.Api.Factories;

public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
{
    public ApplicationContext CreateDbContext(string[] args)
    {
        // Build configuration from appsettings.json for connection string and DbSettings
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", false, true);
        var config = builder.Build();

        // Explicitly configure Serilog for migration logging without reading from configuration.
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .Enrich.FromLogContext()
            .WriteTo.Async(a => a.Console(
                LogEventLevel.Debug,
                "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}"
            ))
            .CreateLogger();

        // Log initialization to confirm logging is active
        Log.Information("Initializing ApplicationContextFactory with explicit logging settings.");

        // Retrieve custom database settings
        var dbSettings = config.GetSection("DbSettings").Get<DbSettings>() ?? new DbSettings();
        var settings = new OptionsWrapper<DbSettings>(dbSettings);

        // Configure the DbContext options with explicit migration assembly settings.
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();

        // Only enable sensitive data logging in development/debug environments
#if DEBUG
        optionsBuilder.EnableSensitiveDataLogging();
#else
        optionsBuilder.EnableSensitiveDataLogging(false);
#endif

        optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"),
            opt => { opt.MigrationsAssembly(settings.Value.MigrationsAssembly); });

        return new ApplicationContext(optionsBuilder.Options, settings);
    }
}