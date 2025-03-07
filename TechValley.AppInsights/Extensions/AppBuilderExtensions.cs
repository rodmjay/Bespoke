#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TechValley.Azure.AppInsights.Configuration;
using TechValley.Azure.AppInsights.Settings;
using TechValley.Azure.Builders;
using TechValley.Core.Helpers;

namespace TechValley.Azure.AppInsights.Extensions;

[ExcludeFromCodeCoverage]
public static class AppBuilderExtensions
{
    private static string GetLogMessage(string message, [CallerMemberName] string callerName = null)
    {
        return $"[{nameof(AppBuilderExtensions)}.{callerName}] - {message}";
    }

    public static AzureBuilder AddAppInsights(this AzureBuilder builder, Action<AppInsightsBuilder>? build = default)
    {
        var settings = builder.GetAppBuilder().ConfigureSettings<AppInsightsSettings>("Azure:AppInsights");

        var insightsBuilder = new AppInsightsBuilder(builder);

        build?.Invoke(insightsBuilder);
        
        builder.Services.AddApplicationInsightsTelemetry(options =>
        {
            // todo: more options to come here
            options.EnableAdaptiveSampling = settings.EnableAdaptiveSampling;
            options.ConnectionString = builder.Configuration.GetConnectionString("AppInsights");
            options.EnableDependencyTrackingTelemetryModule = settings.EnableDependencyTrackingTelemetryModule;  // Enable or disable dependency tracking
            options.DeveloperMode = EnvironmentHelpers.IsDebug();
            options.EnableRequestTrackingTelemetryModule = true;
        });

        builder.Services.AddSingleton<ITelemetryInitializer>(
            new CloudRoleNameTelemetryInitializer(settings.CloudRoleName));

        return builder;
    }

}