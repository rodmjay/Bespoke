namespace AgencyPro.Shared.Models;

public class ProjectManagerStoryOutput : StoryOutput
{
    public override Guid TargetOrganizationId => ProviderOrganizationId;
    public override Guid TargetPersonId => ProjectManagerId;
}