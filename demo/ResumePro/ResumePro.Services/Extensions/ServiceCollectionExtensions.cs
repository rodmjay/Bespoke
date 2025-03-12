using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ResumePro.Services.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }
}