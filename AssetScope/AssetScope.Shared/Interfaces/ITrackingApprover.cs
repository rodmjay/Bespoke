using AssetScope.Shared.Enums;

namespace AssetScope.Shared.Interfaces;

public interface ITrackingApprover
{
    int ContractItemId { get; set; }
    int WorkflowId { get; set; }
    int StepId { get; set; }
    int ActionId { get; set; }
    int ApproverId { get; set; }
    RecipientType RecipientType { get; set; }
    DateTime? ApprovalDate { get; set; }
}