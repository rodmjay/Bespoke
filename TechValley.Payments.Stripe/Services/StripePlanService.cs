namespace TechValley.Payments.Stripe.Services;

public class StripePlanService : StripeClient
{
    public StripePlanService(string? connectId) : base(connectId)
    {
    }
}