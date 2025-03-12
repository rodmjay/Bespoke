using Stripe;

namespace Bespoke.Payments.Stripe.Interfaces;

public interface IStripeFactory
{
    IStripeCustomerClient GetCustomerClient(string customerId);
    IStripeChargeClient GetChargeClient(string chargeId);
    IStripeCardClient GetCardClient(string cardId);
    IStripeSubscriptionClient GetSubscriptionClient(string subscriptionId);
    Task<Customer> CreateCustomerAsync(string email, string name);
}