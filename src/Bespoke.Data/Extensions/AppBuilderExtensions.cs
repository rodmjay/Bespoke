using Bespoke.Core.Builders;
using Bespoke.Core.Helpers;
using Bespoke.Data.Repositories;
using Bespoke.Data.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Bespoke.Data.Extensions;

public static class AppBuilderExtensions
{
    public static AppBuilder AddStorage(this AppBuilder appBuilder,
        Action<DbSettings> configureDbSettings = null,
        Action<DataBuilder> configureDataBuilder = null)
    {
        // Load DbSettings from configuration
        var dbSettings = new DbSettings();
        appBuilder.Configuration.GetSection("DbSettings").Bind(dbSettings);

        // Allow users to modify DbSettings before registering in DI
        configureDbSettings?.Invoke(dbSettings);

        // Register modified DbSettings
        appBuilder.Services.Configure<DbSettings>(options =>
        {
            options.Timeout = dbSettings.Timeout;
            options.MaxRetryCount = dbSettings.MaxRetryCount;
            options.MaxRetryDelaySeconds = dbSettings.MaxRetryDelaySeconds;
            options.MaxBatchSize = dbSettings.MaxBatchSize;
            options.SplitQueries = dbSettings.SplitQueries;
            options.UseContextPooling = dbSettings.UseContextPooling;
            options.MigrationsAssembly = dbSettings.MigrationsAssembly;
            options.ValidateSaves = dbSettings.ValidateSaves;
        });

        // Register core storage services
        appBuilder.Services.TryAddScoped<IUnitOfWorkAsync, UnitOfWork>();
        appBuilder.Services.TryAddScoped<IUnitOfWork, UnitOfWork>();
        appBuilder.Services.TryAddScoped(typeof(IRepositoryAsync<>), typeof(Repository<>));
        appBuilder.Services.TryAddScoped(typeof(IRepository<>), typeof(Repository<>));

        // Allow users to configure DataBuilder for storage provider settings
        var dataBuilder = new DataBuilder(appBuilder, dbSettings);
        configureDataBuilder?.Invoke(dataBuilder);

        return appBuilder;
    }
}
