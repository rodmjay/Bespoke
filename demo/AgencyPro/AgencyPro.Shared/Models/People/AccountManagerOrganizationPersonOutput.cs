namespace AgencyPro.Shared.Models.People
{
    public class AccountManagerOrganizationPersonOutput : OrganizationPersonOutput
    {
        public override Guid TargetOrganizationId => OrganizationId;
    }
}