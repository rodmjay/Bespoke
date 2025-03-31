using System.Reflection;
using Bespoke.Core.Attributes;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bespoke.Core.Extensions
{
    public static class CustomSettingsExtensions
    {
        /// <summary>
        /// Scans for settings classes decorated with [CustomSettings], binds configuration sections using Options,
        /// and applies any additional customizations via a fluent API.
        /// </summary>
        public static IServiceCollection ConfigureApp(
            this IServiceCollection services,
            IConfiguration configuration,
            Action<CustomSettingsBuilder> customize = null)
        {
            var builder = new CustomSettingsBuilder();
            customize?.Invoke(builder);

            // Decide which assemblies to scan.
            // Here we scan the entry assembly (or fallback to the executing assembly).
            var assembly = Assembly.GetEntryAssembly() ?? Assembly.GetExecutingAssembly();
            var settingsTypes = assembly.GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && t.GetCustomAttribute<CustomSettingsAttribute>() != null);

            foreach (var type in settingsTypes)
            {
                var attribute = type.GetCustomAttribute<CustomSettingsAttribute>();
                var section = configuration.GetSection(attribute!.SectionName);

                // Register the binding using the Options pattern:
                // Equivalent to services.Configure<T>(configuration.GetSection("SectionName"));
                var configureMethod = typeof(OptionsConfigurationServiceCollectionExtensions)
                    .GetMethods(BindingFlags.Public | BindingFlags.Static)
                    .FirstOrDefault(m => m.Name == "Configure" &&
                                         m.IsGenericMethodDefinition &&
                                         m.GetParameters().Length == 2);
                if (configureMethod != null)
                {
                    var genericConfigure = configureMethod.MakeGenericMethod(type);
                    genericConfigure.Invoke(null, new object[] { services, section });
                }

                // If a customization exists for this type, add it via PostConfigure<T>
                var tryGetCustomizationMethod = typeof(CustomSettingsBuilder)!
                    .GetMethod(nameof(CustomSettingsBuilder.TryGetCustomization))!
                    .MakeGenericMethod(type);
                var parameters = new object[] { null };
                bool hasCustomization = (bool)tryGetCustomizationMethod.Invoke(builder, parameters)!;
                if (hasCustomization)
                {
                    var customizationDelegate = parameters[0];
                    var postConfigureMethod = typeof(OptionsConfigurationServiceCollectionExtensions)
                        .GetMethods(BindingFlags.Public | BindingFlags.Static)
                        .FirstOrDefault(m => m.Name == "PostConfigure" &&
                                             m.IsGenericMethodDefinition &&
                                             m.GetParameters().Length == 2);
                    if (postConfigureMethod != null)
                    {
                        var genericPostConfigure = postConfigureMethod.MakeGenericMethod(type);
                        genericPostConfigure.Invoke(null, [services, customizationDelegate]);
                    }
                }
            }

            return services;
        }
    }
}
