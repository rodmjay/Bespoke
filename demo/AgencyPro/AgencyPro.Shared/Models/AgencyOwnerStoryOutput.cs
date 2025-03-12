namespace AgencyPro.Shared.Models;

public class AgencyOwnerStoryOutput : StoryOutput
{
    public override Guid TargetOrganizationId => ProviderOrganizationId;
    public override Guid TargetPersonId => ProviderOrganizationOwnerId;
}