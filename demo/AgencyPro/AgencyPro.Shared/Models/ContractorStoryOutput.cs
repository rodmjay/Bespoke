namespace AgencyPro.Shared.Models;

public class ContractorStoryOutput : StoryOutput
{
    public override Guid TargetOrganizationId => ProviderOrganizationId;
    public override Guid TargetPersonId => ContractorOrganizationId.Value;
}