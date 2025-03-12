namespace AgencyPro.Shared.Models.People
{
    public class AccountManagerOrganizationMembershipOutput : OrganizationMembershipOutput
    {
        public override Guid TargetOrganizationId => OrganizationId;
    }
}