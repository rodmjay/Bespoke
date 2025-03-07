using Stripe;
using Bespoke.Shared.Common;

#nullable enable

namespace Bespoke.Payments.Stripe.Interfaces;

public interface IStripeCustomerClient
{
    Task<Charge> CreateChargeAsync(decimal amount, string currency, string description);
    Task<Customer> GetCustomer(CustomerGetOptions options);
    Task<List<Subscription>> ListSubscriptionsAsync();
    Task<Card> CreateCard(CardCreateOptions options);
    Task<Card> UpdateCard(string cardId, CardUpdateOptions options);
    Task<Card> DeleteCard(string cardId, CardDeleteOptions options);
    Task<Subscription> CreateSubscriptionAsync(string priceId, Dictionary<string, string>? metadata = null);


}