namespace AgencyPro.Shared.Models
{
    public class AgencyOwnerStoryOutput : StoryOutput
    {
        public override Guid TargetOrganizationId => this.ProviderOrganizationId;
        public override Guid TargetPersonId => this.ProviderOrganizationOwnerId;
    }
}