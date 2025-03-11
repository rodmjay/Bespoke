namespace AgencyPro.Shared.Models
{
    public class ProjectManagerStoryOutput : StoryOutput
    {
        public override Guid TargetOrganizationId => this.ProviderOrganizationId;
        public override Guid TargetPersonId => this.ProjectManagerId;
    }
}