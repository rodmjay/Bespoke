using Microsoft.Extensions.DependencyInjection.Extensions;
using Bespoke.Core.Builders;
using Bespoke.Core.Helpers;
using Bespoke.Data.Repositories;
using Bespoke.Data.Builders;
namespace Bespoke.Data.Extensions;

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