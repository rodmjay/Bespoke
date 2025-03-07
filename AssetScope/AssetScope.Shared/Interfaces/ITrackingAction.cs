using AssetScope.Shared.Enums;

namespace AssetScope.Shared.Interfaces;

public interface ITrackingAction
{
    int ContractItemId { get; set; }
    int WorkflowId { get; set; }
    int StepId { get; set; }
    int ActionId { get; set; }
    ApprovalType ApprovalType { get; set; }
    DateTime? ApprovalDate { get; set; }
    WorkflowActionType Type { get; set; }
    DateTime? RejectedDate { get; set; }
    DateTime? CompletedDate { get; set; }
}