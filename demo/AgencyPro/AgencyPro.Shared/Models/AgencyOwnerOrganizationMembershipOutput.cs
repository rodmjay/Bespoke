namespace AgencyPro.Shared.Models
{

    public class AgencyOwnerOrganizationMembershipOutput
        : OrganizationMembershipOutput
    {
        public override Guid TargetOrganizationId => this.OrganizationId;
    }
}