using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using Bespoke.Core.Helpers;
using Bespoke.Data.Builders;
using Bespoke.Data.Interfaces;

namespace Bespoke.Data.SqlServer;

public static class DataBuilderExtensions
{
    private static string GetLogMessage(string message, [CallerMemberName] string callerName = null)
    {
        return $"[{nameof(DataBuilderExtensions)}.{callerName}] - {message}";
    }

    public static void UseSqlServer<TContext>(
        this DataBuilder builder,
        Action<SqlSettings> configureSqlSettings = null)
        where TContext : DbContext
    {
        Log.Logger.Debug(GetLogMessage("Adding SQL SERVER"));

        // Load SQL settings from configuration
        var sqlSettings = new SqlSettings();
        builder.Configuration.GetSection("DbSettings:SqlServer").Bind(sqlSettings);

        // Allow users to modify SqlSettings before injecting
        configureSqlSettings?.Invoke(sqlSettings);

        // Register modified SqlSettings
        builder.Services.Configure<SqlSettings>(options =>
        {
            options.ConnectionStringName = sqlSettings.ConnectionStringName;
        });

        // Retrieve connection string
        var connectionString = builder.Configuration.GetConnectionString(sqlSettings.ConnectionStringName);

        if (string.IsNullOrWhiteSpace(connectionString))
        {
            Log.Logger.Fatal(GetLogMessage("Invalid DbSettings or missing Connection String."));
            throw new InvalidOperationException("Database configuration is invalid.");
        }

        // Register the IDataContextAsync if not already registered
        builder.Services.TryAddScoped(typeof(IDataContextAsync), typeof(TContext));

        // SQL Server configuration
        Action<SqlServerDbContextOptionsBuilder> sqlBuilder = sqlOptionsBuilder =>
        {
            sqlOptionsBuilder.UseQuerySplittingBehavior(builder.Settings.SplitQueries
                ? QuerySplittingBehavior.SplitQuery
                : QuerySplittingBehavior.SingleQuery);
            sqlOptionsBuilder.MaxBatchSize(builder.Settings.MaxBatchSize);
            sqlOptionsBuilder.EnableRetryOnFailure(
                builder.Settings.MaxRetryCount,
                TimeSpan.FromSeconds(builder.Settings.MaxRetryDelaySeconds),
                null);
            sqlOptionsBuilder.CommandTimeout(builder.Settings.Timeout);
            sqlOptionsBuilder.MigrationsAssembly(builder.Settings.MigrationsAssembly);
        };

        Action<DbContextOptionsBuilder> optionsAction = options =>
        {
            options.EnableSensitiveDataLogging(EnvironmentHelpers.IsDebug());
            options.UseSqlServer(connectionString, sqlBuilder);
        };

        // Add DbContext with or without pooling based on settings
        if (builder.Settings.UseContextPooling)
        {
            builder.Services.AddDbContextPool<TContext>(optionsAction);
        }
        else
        {
            builder.Services.AddDbContext<TContext>(optionsAction);
        }
    }
}
