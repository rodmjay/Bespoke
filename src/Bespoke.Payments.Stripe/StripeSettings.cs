#nullable enable

namespace Bespoke.Payments.Stripe;

public class StripeSettings
{
    public string? ApiKey { get; set; }
    public bool UseWebHooks { get; set; }
    public bool UseStripeConnect { get; set; }
}