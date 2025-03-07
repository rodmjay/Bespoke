using AssetScope.Shared.Enums;

namespace AssetScope.Shared.Interfaces;

public interface IWorkflowAction
{
    int ActionId { get; set; }
    int StepId { get; set; }
    string? Name { get; set; }
    string? Description { get; set; }
    WorkflowActionType Type { get; set; }
}