namespace AgencyPro.Shared.Options;

public class MarketingOrganizationInput : MarketingOrganizationUpgradeInput
{
    public virtual Guid DefaultMarketerId { get; set; }
}