namespace Bespoke.Azure.AppInsights.Settings;

public class AppInsightsSettings
{
    public string CloudRoleName { get; set; } = null!;
    public bool EnableAdaptiveSampling { get; set; }
    public bool EnableDependencyTrackingTelemetryModule { get; set; }
}