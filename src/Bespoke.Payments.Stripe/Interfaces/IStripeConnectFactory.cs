﻿using Stripe;

namespace Bespoke.Payments.Stripe.Interfaces;

public interface IStripeConnectFactory
{
    IStripeCustomerClient GetCustomerClient(string customerId, string connectId);
    IStripeChargeClient GetChargeClient(string chargeId, string connectId);
    IStripeCardClient GetCardClient(string cardId, string connectId);
    Task<Customer> CreateCustomerAsync(string email, string name, string connectId);
}