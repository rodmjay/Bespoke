#nullable enable

using Stripe;

namespace Bespoke.Payments.Stripe.Services;

public abstract class StripeClient
{
    protected StripeClient(string? connectId)
    {
        if (connectId == null)
            RequestOptions = new RequestOptions();
        else
            RequestOptions = new RequestOptions
            {
                StripeAccount = connectId
            };
    }

    protected RequestOptions RequestOptions { get; }
}