using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bespoke.Core.Builders;

public interface IBuilder
{
    IServiceCollection Services { get; }
    IConfiguration Configuration { get; }
}