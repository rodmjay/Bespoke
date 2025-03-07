#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Stripe;

namespace TechValley.Payments.Stripe.Interfaces;

public interface IStripeConnectFactory
{
    IStripeCustomerClient GetCustomerClient(string customerId, string connectId);
    IStripeChargeClient GetChargeClient(string chargeId, string connectId);
    IStripeCardClient GetCardClient(string cardId, string connectId);
    Task<Customer> CreateCustomerAsync(string email, string name, string connectId);
}