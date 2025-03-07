using System.ComponentModel;

namespace AssetScope.Shared.Enums;

public enum NotificationStatus
{
    [Description("Not Sent")] NotSent = 0,

    [Description("Sent")] Sent = 1
}