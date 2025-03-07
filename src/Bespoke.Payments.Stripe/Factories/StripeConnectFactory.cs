#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Microsoft.Extensions.Options;
using Stripe;
using System.Collections.Concurrent;
using Bespoke.Payments.Stripe.Interfaces;
using Bespoke.Payments.Stripe.Services;

namespace Bespoke.Payments.Stripe.Factories;

public class StripeConnectFactory : IStripeConnectFactory
{
    private readonly ConcurrentDictionary<string, StripeCustomerClient> _customerServiceCache;

    private readonly IOptions<StripeSettings> _settings;
    public StripeConnectFactory(IOptions<StripeSettings> settings)
    {
        _settings = settings;
        _customerServiceCache = new ConcurrentDictionary<string, StripeCustomerClient>();
    }

    public IStripeCustomerClient GetCustomerClient(string customerId, string connectId)
    {
        if (!_customerServiceCache.ContainsKey(customerId))
        {
            var customerService = new StripeCustomerClient(customerId, connectId);
            _customerServiceCache[customerId] = customerService;
        }
        return _customerServiceCache[customerId];
    }

    public IStripeChargeClient GetChargeClient(string chargeId, string connectId)
    {
        return new StripeChargeClient(chargeId);
    }

    public IStripeCardClient GetCardClient(string cardId, string connectId)
    {
        return new StripeCardClient(cardId);
    }

    public async Task<Customer> CreateCustomerAsync(string email, string name, string connectId)
    {
        var customerService = new CustomerService();
        var customer = await customerService.CreateAsync(new CustomerCreateOptions
        {
            Email = email,
            Name = name,
        }, new RequestOptions()
        {
            StripeAccount = connectId
        });

        return customer;
    }
}