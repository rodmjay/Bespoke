namespace AgencyPro.Shared.Models;

public class AccountManagerStoryOutput : StoryOutput
{
    public override Guid ProjectId { get; set; }
    [JsonIgnore] public override DateTimeOffset? AssignedDateTime { get; set; }
    [JsonIgnore] public override DateTimeOffset? ProjectManagerAcceptanceDate { get; set; }
    [JsonIgnore] public override DateTimeOffset? CustomerAcceptanceDate { get; set; }
    public override Guid TargetOrganizationId => ProviderOrganizationId;
    public override Guid TargetPersonId => AccountManagerId;
}