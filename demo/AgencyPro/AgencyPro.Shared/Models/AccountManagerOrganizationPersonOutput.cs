namespace AgencyPro.Shared.Models
{
    public class AccountManagerOrganizationPersonOutput : OrganizationPersonOutput
    {
        public override Guid TargetOrganizationId => this.OrganizationId;
    }
}