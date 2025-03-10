#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using System.Reflection;
using System.Runtime.CompilerServices;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.DependencyModel;
using Serilog;
using Bespoke.Core.Helpers;

namespace Bespoke.Core.Extensions;

public static class ServiceCollectionExtensions
{
    private static string GetLogMessage(string message, [CallerMemberName] string callerName = null)
    {
        return $"[{nameof(ServiceCollectionExtensions)}.{callerName}] - {message}";
    }

    public static AppBuilder AddCompositeRoot(this IServiceCollection services, IConfiguration configuration, Action<AppBuilder> configure = default)
    {
        var builder = CreateAppBuilder(services, configuration);
        configure?.Invoke(builder);
        return builder;
    }

    public static AppBuilder CreateAppBuilder(
        this IServiceCollection services, IConfiguration configuration)
    {
        var appSettings = (configuration, services)
            .ConfigureSettings<AppSettings>("AppSettings");

        services.AddOptions();

        return new AppBuilder(services, appSettings, configuration);
    }
    public static AppBuilder AddAutomapper(
        this AppBuilder builder)
    {
        return AddAutomapperProfilesFromAssemblies2(builder, GetAssemblies());
    }

    public static AppBuilder AddAutomapperProfilesFromAssemblies(
        this AppBuilder builder, string assemblyPrefix)
    {
        var assemblies = AppDomain.CurrentDomain.GetAssemblies()
            .Where(x => x.FullName != null && x.FullName.StartsWith(assemblyPrefix)).ToList();

        return AddAutomapperProfilesFromAssemblies2(builder, assemblies);
    }

    private static AppBuilder AddAutomapperProfilesFromAssemblies2(
        this AppBuilder builder, List<Assembly> assemblies)

    {
        var filteredAssemblies = assemblies.Where(a => a.GetName().Name != "Microsoft.Data.SqlClient");
        var mapperConfig = new MapperConfiguration(cfg =>
        {
            cfg.AddMaps(filteredAssemblies);
        });
        var mapper = mapperConfig.CreateMapper();
        builder.Services.AddSingleton(mapper);
        //builder.Services.TryAddScoped(sp => mapper);

        return builder;
    }

    private static List<Assembly> GetAssemblies()
    {
        // Get all assemblies in the current AppDomain
        var assemblies = DependencyContext.Default.RuntimeLibraries
            .SelectMany(library => library.GetDefaultAssemblyNames(DependencyContext.Default))
            .Where(a => a.Name != "Microsoft.Data.SqlClient")
            .Select(Assembly.Load)
            .ToList();

        foreach (var assembly in assemblies)
        {
            try
            {
                // Search for types that inherit from AutoMapper.Profile
                var profiles = assembly.GetTypes()
                    .Where(type => typeof(Profile).IsAssignableFrom(type) && !type.IsAbstract)
                    .ToList();

                if (profiles.Any())
                {
                    Console.WriteLine($"Assembly: {assembly.FullName}");
                    foreach (var profile in profiles)
                    {
                        Console.WriteLine($"  Found Profile: {profile.FullName}");
                    }
                }
            }
            catch (ReflectionTypeLoadException ex)
            {
                // Handle cases where types in an assembly cannot be loaded
                Console.WriteLine($"Error loading types from assembly: {assembly.FullName}");
                foreach (var loaderException in ex.LoaderExceptions)
                {
                    Console.WriteLine($"  Loader Exception: {loaderException.Message}");
                }
            }
        }

        return assemblies.ToList();
    }
}
