namespace Bespoke.Payments.Stripe;

public class StripeWebHookSettings
{
    public string EndpointUrl { get; set; } = "";
    public List<string> Events { get; set; } = new();
}