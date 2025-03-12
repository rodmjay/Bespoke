namespace AgencyPro.Shared.Models;

public class ProjectManagerFixedPriceProposalDetailsOutput : ProjectManagerFixedPriceProposalOutput
{
    public ProposalAcceptanceDetailOutput ProposalAcceptance { get; set; }
    public ICollection<ProposedContractOutput> ProposedContracts { get; set; }
    public ICollection<ProposedStoryOutput> ProposedStories { get; set; }
    public Dictionary<DateTimeOffset, ProposalStatus> StatusTransitions { get; set; }
}