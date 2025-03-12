namespace AgencyPro.Shared.Models;

public class CustomerStoryOutput : StoryOutput
{
    public override Guid TargetOrganizationId => CustomerOrganizationId;
    public override Guid TargetPersonId => CustomerId;
}