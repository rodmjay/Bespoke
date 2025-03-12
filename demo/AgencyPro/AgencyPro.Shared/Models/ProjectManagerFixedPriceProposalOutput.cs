namespace AgencyPro.Shared.Models;

public class ProjectManagerFixedPriceProposalOutput : FixedPriceProposalOutput
{
    public override Guid TargetOrganizationId => ProjectManagerOrganizationId;
    public override Guid TargetPersonId => ProjectManagerId;
}