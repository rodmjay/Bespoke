namespace Bespoke.Shared.Interfaces;

public interface ICustomEventLogger
{
    void LogCustomEvent(string eventName, IDictionary<string, string> properties = null,
        IDictionary<string, double> metrics = null);

    /// <summary>
    ///     Logs a custom metric to Application Insights.
    /// </summary>
    /// <param name="metricName">The name of the metric.</param>
    /// <param name="value">The value of the metric.</param>
    /// <param name="properties">Optional properties associated with the metric.</param>
    void LogMetric(string metricName, double value, IDictionary<string, string> properties = null);
}