namespace AssetScope.Shared.Interfaces;

public interface ITrackingStep
{
    int ContractItemId { get; set; }
    int WorkflowId { get; set; }
    bool IsInitialStep { get; set; }
    bool IsFinalStep { get; set; }
    int StepId { get; set; }
}