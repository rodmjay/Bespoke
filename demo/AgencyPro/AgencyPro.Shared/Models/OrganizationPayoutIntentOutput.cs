namespace AgencyPro.Shared.Models;

public class OrganizationPayoutIntentOutput : PayoutViewModel, IOrganizationPayoutIntent
{
    public string OrganizationName { get; set; }
}