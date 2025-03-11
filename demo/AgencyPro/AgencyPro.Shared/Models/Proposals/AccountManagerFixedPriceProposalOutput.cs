namespace AgencyPro.Shared.Models.Proposals
{
    public class AccountManagerFixedPriceProposalOutput : FixedPriceProposalOutput
    {
        public override Guid TargetOrganizationId => AccountManagerOrganizationId;
        public override Guid TargetPersonId => AccountManagerId;

    }
}