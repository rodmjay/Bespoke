namespace AssetScope.Shared.Interfaces;

public interface ITrackingWorkflow
{
    int ContractItemId { get; set; }
    int WorkflowId { get; set; }
    int CurrentStep { get; set; }
}