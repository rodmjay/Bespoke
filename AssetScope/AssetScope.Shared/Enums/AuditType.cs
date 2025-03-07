using System.ComponentModel;

namespace AssetScope.Shared.Enums;

public enum AuditType
{
    [Description("Contract Created")] ContractCreated = 0,

    [Description("Contract Updated")] ContractUpdated = 1,

    [Description("Contract Rejected")] ContractRejected = 2,

    [Description("Contract Submitted")] ContractSubmitted = 3,

    [Description("Contract Terminated")] ContractTerminated = 4,

    [Description("Contract Deleted")] ContractDeleted = 5,

    [Description("Contract Cancelled")] ContractCancelled = 6,

    [Description("Contract UnSubmitted")] ContractUnSubmitted = 7,

    [Description("Contract Reassigned")] ContractReassigned = 8,

    [Description("Attachment Deleted")] AttachmentDeleted = 9,

    [Description("Attachment Updated")] AttachmentUpdated = 10
}