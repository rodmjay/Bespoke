using System.ComponentModel;

namespace AssetScope.Shared.Enums;

public enum ApprovalStatus
{
    [Description("Draft")] Draft = 0,

    [Description("Submitted")] Submitted = 1,

    [Description("Approved")] Approved = 2,

    [Description("Rejected")] Rejected = 3,

    [Description("Cancelled")] Cancelled = 4,

    [Description("Terminate")] Terminated = 5
}