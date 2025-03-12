using Bespoke.Core.Builders;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bespoke.Data.Builders;

public class DataBuilder : IBuilder
{
    private readonly AppBuilder _appBuilder;

    public DataBuilder(AppBuilder appBuilder, DbSettings settings)
    {
        Settings = settings;
        _appBuilder = appBuilder;
    }

    public DbSettings Settings { get; }

    public IServiceCollection Services => _appBuilder.Services;

    public IConfiguration Configuration => _appBuilder.Configuration;
}