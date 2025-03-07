namespace AssetScope.Shared.Interfaces;

public interface IWorkflowDependency
{
    int ActionId { get; set; } // Action that has dependencies
    int DependentActionId { get; set; } // Action that must also be completed
}