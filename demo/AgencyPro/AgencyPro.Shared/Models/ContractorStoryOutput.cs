namespace AgencyPro.Shared.Models
{
    public class ContractorStoryOutput : StoryOutput
    {
        public override Guid TargetOrganizationId => this.ProviderOrganizationId;
        public override Guid TargetPersonId => this.ContractorOrganizationId.Value;
    }
}