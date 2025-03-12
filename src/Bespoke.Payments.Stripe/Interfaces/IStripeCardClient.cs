using Stripe;

namespace Bespoke.Payments.Stripe.Interfaces;

public interface IStripeCardClient
{
    Task<Card> UpdateCard(string customerId, CardUpdateOptions options);
    Task<Card> DeleteCard(string customerId, CardDeleteOptions options);
}