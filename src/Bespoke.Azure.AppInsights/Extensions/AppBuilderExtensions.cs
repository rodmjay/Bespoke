using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Bespoke.Azure.AppInsights.Configuration;
using Bespoke.Azure.AppInsights.Settings;
using Bespoke.Azure.Builders;
using Bespoke.Core.Helpers;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bespoke.Azure.AppInsights.Extensions;

[ExcludeFromCodeCoverage]
public static class AppBuilderExtensions
{
    public static AzureBuilder AddAppInsights(this AzureBuilder builder, Action<AppInsightsBuilder> build = null)
    {
        var settings = builder.GetAppBuilder().ConfigureSettings<AppInsightsSettings>("AzureSettings:AppInsights");

        var insightsBuilder = new AppInsightsBuilder(builder);

        build?.Invoke(insightsBuilder);

        builder.Services.AddApplicationInsightsTelemetry(options =>
        {
            // todo: more options to come here
            options.EnableAdaptiveSampling = settings.EnableAdaptiveSampling;
            options.ConnectionString = builder.Configuration.GetConnectionString("AppInsights");
            options.EnableDependencyTrackingTelemetryModule =
                settings.EnableDependencyTrackingTelemetryModule; // Enable or disable dependency tracking
            options.DeveloperMode = EnvironmentHelpers.IsDebug();
            options.EnableRequestTrackingTelemetryModule = true;
        });

        builder.Services.AddSingleton<ITelemetryInitializer>(
            new CloudRoleNameTelemetryInitializer(settings.CloudRoleName));

        return builder;
    }
}