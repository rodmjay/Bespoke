#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Stripe;

#nullable enable

namespace Bespoke.Payments.Stripe.Interfaces;

public interface IStripeSubscriptionClient
{
    Task<Subscription> GetSubscriptionAsync(SubscriptionGetOptions? options = null);
    Task<Subscription> UpdateSubscriptionAsync( SubscriptionUpdateOptions options);
    Task<bool> CancelSubscriptionAsync(SubscriptionCancelOptions options);
}