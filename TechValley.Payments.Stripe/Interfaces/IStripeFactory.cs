#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Stripe;
using TechValley.Payments.Stripe.Services;

namespace TechValley.Payments.Stripe.Interfaces;

public interface IStripeFactory
{
    IStripeCustomerClient GetCustomerClient(string customerId);
    IStripeChargeClient GetChargeClient(string chargeId);
    IStripeCardClient GetCardClient(string cardId);
    IStripeSubscriptionClient GetSubscriptionClient(string subscriptionId);
    Task<Customer> CreateCustomerAsync(string email, string name);
}