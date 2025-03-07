namespace AssetScope.Shared.Interfaces;

public interface IWorkflowStep
{
    int StepId { get; set; }
    int WorkflowId { get; set; }
    string? Name { get; set; }
    string? Description { get; set; }
    bool IsFinalStage { get; set; }
    bool IsInitialStage { get; set; }
}