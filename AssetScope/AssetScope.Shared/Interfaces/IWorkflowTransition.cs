namespace AssetScope.Shared.Interfaces;

public interface IWorkflowTransition
{
    int TransitionId { get; set; }
    int ActionId { get; set; }
    int? ToStepId { get; set; }
}