namespace AgencyPro.Shared.Models;

public class MarketerOrganizationOutput : MarketingOrganizationOutput
{
    [JsonIgnore] public override decimal ServiceFeePerLead { get; set; }
}