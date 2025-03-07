#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Microsoft.AspNetCore.Authentication;
using Stripe;
using Stripe.Forwarding;
using Bespoke.Payments.Stripe.Interfaces;

namespace Bespoke.Payments.Stripe.Services;

public class StripeCustomerClient : StripeClient, IStripeCustomerClient
{
    private readonly string _customerId;

    public StripeCustomerClient(string customerId, string? stripeConnectId = null) : base(stripeConnectId)
    {
        _customerId = customerId;
    }

    public async Task<Customer> GetCustomer(CustomerGetOptions options)
    {
        var customerService = new CustomerService();
        var customer = await customerService.GetAsync(_customerId, options, RequestOptions);
        return customer;
    }

    public async Task<List<Subscription>> ListSubscriptionsAsync()
    {
        var subscriptionService = new SubscriptionService();
        var options = new SubscriptionListOptions
        {
            Customer = _customerId
        };

        var subscriptions = await subscriptionService.ListAsync(options, RequestOptions);
        return subscriptions.Data;
    }

    public async Task<Card> CreateCard(CardCreateOptions options)
    {
        var cardService = new CardService();
        var card = await cardService.CreateAsync(_customerId, options, RequestOptions);

        return card;
    }

    public async Task<Card> UpdateCard(string cardId, CardUpdateOptions options)
    {
        var cardService = new CardService();
        var card = await cardService.UpdateAsync(_customerId, cardId, options, RequestOptions);

        return card;
    }

    public async Task<Card> DeleteCard(string cardId, CardDeleteOptions options)
    {
        var cardService = new CardService();
        var card = await cardService.DeleteAsync(_customerId, cardId, options, RequestOptions);
        return card;
    }

    public async Task<Charge> CreateChargeAsync(decimal amount, string currency, string description)
    {
        var chargeService = new ChargeService();
        var charge = await chargeService.CreateAsync(new ChargeCreateOptions
        {
            Customer = _customerId,
            Amount = Convert.ToInt64(amount * 100),
            Currency = currency,
            Description = description,
        }, RequestOptions);

        return charge;
    }


    public async Task<Subscription> CreateSubscriptionAsync(string priceId, Dictionary<string, string>? metadata = null)
    {
        var subscriptionService = new SubscriptionService();
        var options = new SubscriptionCreateOptions
        {
            Customer = _customerId,
            Items = new List<SubscriptionItemOptions>
            {
                new SubscriptionItemOptions
                {
                    Price = priceId
                }
            },
            Metadata = metadata
        };

        return await subscriptionService.CreateAsync(options);
    }
}

