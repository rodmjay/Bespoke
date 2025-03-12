using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bespoke.Core.Builders;

public abstract class BuilderBase : IBuilder
{
    protected BuilderBase(IBuilder builder)
    {
        Services = builder.Services;
        Configuration = builder.Configuration;
    }

    public IServiceCollection Services { get; }
    public IConfiguration Configuration { get; }


    public (IConfiguration, IServiceCollection) GetAppBuilder()
    {
        return (Configuration, Services);
    }
}