using System.Runtime.CompilerServices;
using Bespoke.Core.Helpers;
using Bespoke.Data.Builders;
using Bespoke.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure;
using Serilog;

namespace Bespoke.Data.PostgreSQL;

public static class DataBuilderExtensions
{
    private static string GetLogMessage(string message, [CallerMemberName] string? callerName = null)
    {
        return $"[{nameof(DataBuilderExtensions)}.{callerName}] - {message}";
    }

    public static void UsePostgreSQL<TContext>(
        this DataBuilder builder,
        Action<PostgreSQLSettings>? configurePostgreSQLSettings = null)
        where TContext : DbContext
    {
        Log.Logger.Debug(GetLogMessage("Adding POSTGRESQL"));

        // Load PostgreSQL settings from configuration
        var postgreSQLSettings = new PostgreSQLSettings();
        builder.Configuration.GetSection("DbSettings:PostgreSQL").Bind(postgreSQLSettings);

        // Allow users to modify PostgreSQLSettings before injecting
        configurePostgreSQLSettings?.Invoke(postgreSQLSettings);

        // Register modified PostgreSQLSettings
        builder.Services.Configure<PostgreSQLSettings>(options =>
        {
            options.ConnectionStringName = postgreSQLSettings.ConnectionStringName;
        });

        // Retrieve connection string
        var connectionString = builder.Configuration.GetConnectionString(postgreSQLSettings.ConnectionStringName);

        if (string.IsNullOrWhiteSpace(connectionString))
        {
            Log.Logger.Fatal(GetLogMessage("Invalid DbSettings or missing Connection String."));
            throw new InvalidOperationException("Database configuration is invalid.");
        }

        // Register the IDataContextAsync if not already registered
        builder.Services.TryAddScoped(typeof(IDataContextAsync), typeof(TContext));

        // PostgreSQL configuration
        Action<NpgsqlDbContextOptionsBuilder> postgresBuilder = postgresOptionsBuilder =>
        {
            postgresOptionsBuilder.MigrationsAssembly(builder.Settings.MigrationsAssembly);
            postgresOptionsBuilder.EnableRetryOnFailure(
                builder.Settings.MaxRetryCount,
                TimeSpan.FromSeconds(builder.Settings.MaxRetryDelaySeconds),
                null);
            postgresOptionsBuilder.CommandTimeout(builder.Settings.Timeout);
        };

        Action<DbContextOptionsBuilder> optionsAction = options =>
        {
            options.EnableSensitiveDataLogging(EnvironmentHelpers.IsDebug());
            options.UseNpgsql(connectionString, postgresBuilder);
        };

        // Add DbContext with or without pooling based on settings
        if (builder.Settings.UseContextPooling)
            builder.Services.AddDbContextPool<TContext>(optionsAction);
        else
            builder.Services.AddDbContext<TContext>(optionsAction);
    }
}
