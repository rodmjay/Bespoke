namespace AgencyPro.Shared.Models
{
    public class FixedPriceProposalDetailOutput : FixedPriceProposalOutput
    {
        public override Guid TargetOrganizationId => this.ProjectManagerOrganizationId;

        public override Guid TargetPersonId => this.ProviderOrganizationOwnerId;

        public ProposalAcceptanceDetailOutput ProposalAcceptance { get; set; }
        public ICollection<ProposedContractOutput> ProposedContracts { get; set; }
        public ICollection<ProposedStoryOutput> ProposedStories { get; set; }
    }
}
