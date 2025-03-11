namespace AgencyPro.Shared.Models
{
    public class AgencyOwnerProjectOutput : ProjectOutput
    {
        public override Guid TargetOrganizationId => this.ProjectManagerOrganizationId;
        public override Guid TargetPersonId => this.ProjectManagerId;
    }
}