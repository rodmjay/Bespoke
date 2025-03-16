using System.Runtime.CompilerServices;
using Bespoke.Core.Helpers;
using Bespoke.Data.Builders;
using Bespoke.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Serilog;

namespace Bespoke.Data.SQLite;

public static class DataBuilderExtensions
{
    private static string GetLogMessage(string message, [CallerMemberName] string callerName = null)
    {
        return $"[{nameof(DataBuilderExtensions)}.{callerName}] - {message}";
    }

    public static void UseSQLite<TContext>(
        this DataBuilder builder,
        Action<SQLiteSettings> configureSqliteSettings = null)
        where TContext : DbContext
    {
        Log.Logger.Debug(GetLogMessage("Adding SQLITE"));

        // Load SQLite settings from configuration
        var sqliteSettings = new SQLiteSettings();
        builder.Configuration.GetSection("DbSettings:SQLite").Bind(sqliteSettings);

        // Allow users to modify SQLiteSettings before injecting
        configureSqliteSettings?.Invoke(sqliteSettings);

        // Register modified SQLiteSettings
        builder.Services.Configure<SQLiteSettings>(options =>
        {
            options.ConnectionStringName = sqliteSettings.ConnectionStringName;
        });

        // Retrieve connection string
        var connectionString = builder.Configuration.GetConnectionString(sqliteSettings.ConnectionStringName);

        if (string.IsNullOrWhiteSpace(connectionString))
        {
            Log.Logger.Fatal(GetLogMessage("Invalid DbSettings or missing Connection String."));
            throw new InvalidOperationException("Database configuration is invalid.");
        }

        // Register the IDataContextAsync if not already registered
        builder.Services.TryAddScoped(typeof(IDataContextAsync), typeof(TContext));

        // SQLite configuration
        Action<SqliteDbContextOptionsBuilder> sqliteBuilder = sqliteOptionsBuilder =>
        {
            // Set the migrations assembly if needed
            sqliteOptionsBuilder.MigrationsAssembly(builder.Settings.MigrationsAssembly);
            // You can configure additional SQLite-specific options here if necessary.
        };

        Action<DbContextOptionsBuilder> optionsAction = options =>
        {
            options.EnableSensitiveDataLogging(EnvironmentHelpers.IsDebug());
            options.UseSqlite(connectionString, sqliteBuilder);
        };

        // Add DbContext with or without pooling based on settings
        if (builder.Settings.UseContextPooling)
            builder.Services.AddDbContextPool<TContext>(optionsAction);
        else
            builder.Services.AddDbContext<TContext>(optionsAction);
    }
}
