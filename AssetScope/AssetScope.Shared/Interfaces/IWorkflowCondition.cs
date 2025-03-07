using AssetScope.Shared.Enums;

namespace AssetScope.Shared.Interfaces;

public interface IWorkflowCondition
{
    int ConditionId { get; set; } // Primary key for the condition
    WorkflowConditionType Type { get; set; } // Enum to define the type of condition
    int ActionId { get; set; }
}