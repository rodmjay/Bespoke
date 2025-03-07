namespace TechValley.Azure.AppInsights.Settings
{
    public class AppInsightsSettings
    {
        public string CloudRoleName { get; set; }
        public bool EnableAdaptiveSampling { get; set; }
        public bool EnableDependencyTrackingTelemetryModule { get; set; }
    }
}
