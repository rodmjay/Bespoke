using System.Diagnostics.CodeAnalysis;
using Bespoke.Azure.AppInsights.Configuration;
using Bespoke.Azure.AppInsights.Settings;
using Bespoke.Azure.Builders;
using Bespoke.Core.Helpers;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bespoke.Azure.AppInsights.Extensions
{
    [ExcludeFromCodeCoverage]
    public static class AppBuilderExtensions
    {
        public static AzureBuilder AddAppInsights(
            this AzureBuilder builder,
            Action<AppInsightsSettings> configureAppInsightsSettings = null,
            Action<AppInsightsBuilder> configureAppInsightsBuilder = null)
        {
            // Load AppInsightsSettings from configuration
            var appInsightsSettings = new AppInsightsSettings();
            builder.Configuration
                .GetSection("AzureSettings:AppInsights")
                .Bind(appInsightsSettings);

            // Allow the user to modify settings before they are used
            configureAppInsightsSettings?.Invoke(appInsightsSettings);

            // Create the AppInsightsBuilder to enable further configuration
            var insightsBuilder = new AppInsightsBuilder(builder);
            configureAppInsightsBuilder?.Invoke(insightsBuilder);

            // Register Application Insights telemetry using the settings
            builder.Services.AddApplicationInsightsTelemetry(options =>
            {
                options.EnableAdaptiveSampling = appInsightsSettings.EnableAdaptiveSampling;
                options.ConnectionString = builder.Configuration.GetConnectionString("AppInsights");
                options.EnableDependencyTrackingTelemetryModule = appInsightsSettings.EnableDependencyTrackingTelemetryModule;
                options.DeveloperMode = EnvironmentHelpers.IsDebug();
                options.EnableRequestTrackingTelemetryModule = true;
            });

            // Register a telemetry initializer with the configured Cloud Role Name
            builder.Services.AddSingleton<ITelemetryInitializer>(
                new CloudRoleNameTelemetryInitializer(appInsightsSettings.CloudRoleName));

            return builder;
        }
    }
}
