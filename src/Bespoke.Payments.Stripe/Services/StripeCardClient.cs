#nullable enable

using Bespoke.Payments.Stripe.Interfaces;
using Stripe;

namespace Bespoke.Payments.Stripe.Services;

public class StripeCardClient : StripeClient, IStripeCardClient
{
    private readonly string _cardId;

    public StripeCardClient(string cardId, string? connectId = null) : base(connectId)
    {
        _cardId = cardId;
    }

    public Task<Card> UpdateCard(string customerId, CardUpdateOptions options)
    {
        throw new NotImplementedException();
    }

    public Task<Card> DeleteCard(string customerId, CardDeleteOptions options)
    {
        throw new NotImplementedException();
    }
}