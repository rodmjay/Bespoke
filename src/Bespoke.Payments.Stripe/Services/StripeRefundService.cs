#nullable enable

namespace Bespoke.Payments.Stripe.Services;

public class StripeRefundService : StripeClient
{
    public StripeRefundService(string? connectId) : base(connectId)
    {
    }
}