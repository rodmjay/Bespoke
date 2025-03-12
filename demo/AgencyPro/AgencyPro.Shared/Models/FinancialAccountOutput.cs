using Newtonsoft.Json.Converters;

namespace AgencyPro.Shared.Models;

public class FinancialAccountOutput : IFinancialAccount
{
    [JsonConverter(typeof(StringEnumConverter))]
    public FinancialAccountStatus Status { get; set; }

    public bool ChargesEnabled { get; set; }

    public bool PayoutsEnabled { get; set; }
    public string AccountId { get; set; }
}