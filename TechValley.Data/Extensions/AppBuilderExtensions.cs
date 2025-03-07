using Microsoft.Extensions.DependencyInjection.Extensions;
using TechValley.Core.Builders;
using TechValley.Core.Helpers;
using TechValley.Data.Repositories;
using TechValley.Data.Builders;
namespace TechValley.Data.Extensions;

public static class AppBuilderExtensions
{
    public static AppBuilder AddStorage(this AppBuilder appBuilder, Action<DataBuilder> configure = default)
    {
        (appBuilder.Configuration, appBuilder.Services)
            .ConfigureSettings<DbSettings>("DbSettings");

        appBuilder.Services.TryAddScoped(typeof(IUnitOfWorkAsync), typeof(UnitOfWork));
        appBuilder.Services.TryAddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
        appBuilder.Services.TryAddScoped(typeof(IRepositoryAsync<>), typeof(Repository<>));
        appBuilder.Services.TryAddScoped(typeof(IRepository<>), typeof(Repository<>));

        var dataBuilder = new DataBuilder(appBuilder);
        configure?.Invoke(dataBuilder);

        return appBuilder;
    }
}