#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using TechValley.Core.Helpers;
using TechValley.Data.Builders;
using TechValley.Data.Interfaces;

namespace TechValley.Data.SqlServer;

public static class DataBuilderExtensions
{
    private static string GetLogMessage(string message, [CallerMemberName] string callerName = null)
    {
        return $"[{nameof(DataBuilderExtensions)}.{callerName}] - {message}";
    }
    public static void UseSqlServer<TContext>(this DataBuilder builder)
        where TContext : DbContext
    {
        Log.Logger.Debug(GetLogMessage("Adding SQL SERVER"));

        var settings = (builder.Configuration, builder.Services)
            .ConfigureSettings<SqlSettings>("DbSettings:SqlServer");

        var dbSettings = builder.Services
            .BuildServiceProvider()
            .GetRequiredService<IOptions<DbSettings>>();
        
        // Register the IDataContextAsync if not already registered
        builder.Services.TryAddScoped(typeof(IDataContextAsync), typeof(TContext));

        var connectionString = builder.Configuration.GetConnectionString(settings.ConnectionStringName);

        if (string.IsNullOrWhiteSpace(connectionString))
        {
            Log.Logger.Fatal(GetLogMessage("Invalid DbSettings or missing Connection String."));
            throw new InvalidOperationException("Database configuration is invalid.");
        }

        Action<SqlServerDbContextOptionsBuilder> sqlBuilder = sqlOptionsBuilder =>
        {
            sqlOptionsBuilder.UseQuerySplittingBehavior(dbSettings.Value.SplitQueries
                ? QuerySplittingBehavior.SplitQuery
                : QuerySplittingBehavior.SingleQuery);
            sqlOptionsBuilder.MaxBatchSize(dbSettings.Value.MaxBatchSize);
            sqlOptionsBuilder.EnableRetryOnFailure(
                dbSettings.Value.MaxRetryCount,
                TimeSpan.FromSeconds(dbSettings.Value.MaxRetryDelaySeconds),
                null);
            sqlOptionsBuilder.CommandTimeout(dbSettings.Value.Timeout);
            sqlOptionsBuilder.MigrationsAssembly(dbSettings.Value.MigrationsAssembly);
        };

        Action<DbContextOptionsBuilder> optionsAction = options =>
        {
            options.EnableSensitiveDataLogging(EnvironmentHelpers.IsDebug());
            options.UseSqlServer(connectionString, sqlBuilder);  // Use connection string directly here
        };

        // Add DbContext with or without pooling based on settings
        if (dbSettings.Value.UseContextPooling)
        {
            builder.Services.AddDbContextPool<TContext>(optionsAction);
        }
        else
        {
            builder.Services.AddDbContext<TContext>(optionsAction);
        }
    }

}