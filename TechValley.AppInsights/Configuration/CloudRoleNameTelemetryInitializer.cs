using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility;

namespace TechValley.Azure.AppInsights.Configuration
{
    public class CloudRoleNameTelemetryInitializer(string roleName) : ITelemetryInitializer
    {
        public void Initialize(ITelemetry telemetry)
        {
            if (string.IsNullOrEmpty(telemetry.Context.Cloud.RoleName)) telemetry.Context.Cloud.RoleName = roleName;
        }
    }
}
