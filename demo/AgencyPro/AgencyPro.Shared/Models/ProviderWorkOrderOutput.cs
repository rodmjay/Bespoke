namespace AgencyPro.Shared.Models;

public class ProviderWorkOrderOutput : WorkOrderOutput
{
    [JsonIgnore] public override int BuyerNumber { get; set; }

    [JsonProperty("number")] public override int ProviderNumber { get; set; }

    public override Guid TargetOrganizationId => AccountManagerOrganizationId;


    public override Guid TargetPersonId => AccountManagerId;
}