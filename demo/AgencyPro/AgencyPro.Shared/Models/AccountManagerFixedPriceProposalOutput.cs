namespace AgencyPro.Shared.Models
{
    public class AccountManagerFixedPriceProposalOutput : FixedPriceProposalOutput
    {
        public override Guid TargetOrganizationId => this.AccountManagerOrganizationId;
        public override Guid TargetPersonId => this.AccountManagerId;

    }
}