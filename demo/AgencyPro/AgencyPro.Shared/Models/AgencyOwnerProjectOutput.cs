namespace AgencyPro.Shared.Models;

public class AgencyOwnerProjectOutput : ProjectOutput
{
    public override Guid TargetOrganizationId => ProjectManagerOrganizationId;
    public override Guid TargetPersonId => ProjectManagerId;
}