namespace AgencyPro.Shared.Models
{
    public class CustomerStoryOutput : StoryOutput
    {
        public override Guid TargetOrganizationId => this.CustomerOrganizationId;
        public override Guid TargetPersonId => this.CustomerId;
    }
}