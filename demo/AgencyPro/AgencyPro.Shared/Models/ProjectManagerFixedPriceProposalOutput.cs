namespace AgencyPro.Shared.Models
{
    public class ProjectManagerFixedPriceProposalOutput : FixedPriceProposalOutput
    {
        public override Guid TargetOrganizationId => this.ProjectManagerOrganizationId;
        public override Guid TargetPersonId => this.ProjectManagerId;
    }
}