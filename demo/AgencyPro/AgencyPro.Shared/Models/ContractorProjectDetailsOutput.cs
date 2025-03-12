namespace AgencyPro.Shared.Models;

public class ContractorProjectDetailsOutput : ContractorProjectOutput
{
    public ICollection<ContractorStoryOutput> Stories { get; set; }
    public ICollection<ContractorContractOutput> Contracts { get; set; }
    public ICollection<CommentOutput> Comments { get; set; }
    public Dictionary<DateTimeOffset, ProjectStatus> StatusTransitions { get; set; }
}