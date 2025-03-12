using Bespoke.Core.Builders;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bespoke.Rest.Builders;

public class RestApiBuilder(AppBuilder appBuilder, RestSettings restSettings)
{
    public IConfiguration Configuration => appBuilder.Configuration;

    public AppSettings AppSettings => appBuilder.AppSettings;
    public RestSettings RestSetings => restSettings;
    public IServiceCollection Services => appBuilder.Services;
}