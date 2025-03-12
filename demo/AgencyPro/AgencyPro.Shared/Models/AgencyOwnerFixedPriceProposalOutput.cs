namespace AgencyPro.Shared.Models;

public class AgencyOwnerFixedPriceProposalOutput : FixedPriceProposalOutput
{
    public override Guid TargetOrganizationId => ProjectManagerOrganizationId;
    public override Guid TargetPersonId => ProviderOrganizationOwnerId;
}