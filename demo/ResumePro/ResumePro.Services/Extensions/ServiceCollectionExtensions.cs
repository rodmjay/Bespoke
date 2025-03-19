using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ResumePro.Services.Implementations;
using ResumePro.Services.Interfaces;

namespace ResumePro.Services.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        // Register error describers
        services.AddErrorDescribers();
        
        // Register all services
        services.AddScoped<IPeopleService, PeopleService>();
        services.AddScoped<ISkillService, SkillService>();
        
        return services;
    }
}
