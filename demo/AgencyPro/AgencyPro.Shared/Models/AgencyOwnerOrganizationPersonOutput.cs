namespace AgencyPro.Shared.Models
{

    public class AgencyOwnerOrganizationPersonOutput
        : OrganizationPersonOutput
    {
        public override Guid TargetOrganizationId => this.OrganizationId;
    }
}