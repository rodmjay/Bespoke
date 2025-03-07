using System.ComponentModel;

namespace AssetScope.Shared.Enums;

public enum NotificationType
{
    [Description("None")] None = 0,

    [Description("Action Completed Notice")]
    ActionCompleteNotice = 1,

    [Description("Action Status Update Notice")]
    ActionStatusUpdateNotice = 2,

    [Description("Contract Reassigned")] ContractReassigned = 3,

    [Description("Approval Ready")] ApprovalReady = 4
}