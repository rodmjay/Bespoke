namespace AgencyPro.Shared.Models;

public class BuyerWorkOrderOutput : WorkOrderOutput
{
    [JsonProperty("number")] public override int BuyerNumber { get; set; }

    [JsonIgnore] public override int ProviderNumber { get; set; }

    public override Guid TargetOrganizationId => CustomerOrganizationId;
    public override Guid TargetPersonId => CustomerId;
}