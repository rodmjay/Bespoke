#nullable enable

using Stripe;

namespace Bespoke.Payments.Stripe.Interfaces;

public interface IStripeSubscriptionClient
{
    Task<Subscription> GetSubscriptionAsync(SubscriptionGetOptions? options = null);
    Task<Subscription> UpdateSubscriptionAsync(SubscriptionUpdateOptions options);
    Task<bool> CancelSubscriptionAsync(SubscriptionCancelOptions options);
}