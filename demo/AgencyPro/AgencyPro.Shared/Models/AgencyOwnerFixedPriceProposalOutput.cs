namespace AgencyPro.Shared.Models
{
    public class AgencyOwnerFixedPriceProposalOutput : FixedPriceProposalOutput
    {
        public override Guid TargetOrganizationId => this.ProjectManagerOrganizationId;
        public override Guid TargetPersonId => this.ProviderOrganizationOwnerId;
        
    }
}