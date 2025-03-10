using Bespoke.Shared.Interfaces;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;

namespace Bespoke.Azure.AppInsights.Services;

public sealed class CustomEventLogger : ICustomEventLogger
{
    private readonly TelemetryClient _telemetryClient;

    public CustomEventLogger(TelemetryConfiguration telemetryConfiguration)
    {
        if (telemetryConfiguration == null)
            throw new ArgumentNullException(nameof(telemetryConfiguration));

        _telemetryClient = new TelemetryClient(telemetryConfiguration);
    }

    public void LogCustomEvent(string eventName, IDictionary<string, string> properties = null,
        IDictionary<string, double> metrics = null)
    {
        if (string.IsNullOrWhiteSpace(eventName))
            throw new ArgumentException("Event name must be provided.", nameof(eventName));

        try
        {
            _telemetryClient.TrackEvent(eventName, properties, metrics);
        }
        catch (Exception ex)
        {
            // Optionally handle/log the exception
            Console.Error.WriteLine($"Error tracking event '{eventName}': {ex}");
        }
    }

    /// <summary>
    ///     Logs a custom metric to Application Insights.
    /// </summary>
    /// <param name="metricName">The name of the metric.</param>
    /// <param name="value">The value of the metric.</param>
    /// <param name="properties">Optional properties associated with the metric.</param>
    public void LogMetric(string metricName, double value, IDictionary<string, string> properties = null)
    {
        if (string.IsNullOrWhiteSpace(metricName))
            throw new ArgumentException("Metric name must be provided.", nameof(metricName));

        try
        {
            _telemetryClient.TrackMetric(metricName, value, properties);
        }
        catch (Exception ex)
        {
            // Optionally handle/log the exception
            Console.Error.WriteLine($"Error tracking metric '{metricName}': {ex}");
        }
    }
}