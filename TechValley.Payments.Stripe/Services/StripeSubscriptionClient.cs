#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Stripe;
using TechValley.Payments.Stripe.Interfaces;

namespace TechValley.Payments.Stripe.Services;

public class StripeSubscriptionClient : StripeClient, IStripeSubscriptionClient
{
    private readonly string _subscriptionId;

    public StripeSubscriptionClient(string subscriptionId, string? connectId) :base(connectId)
    {
        _subscriptionId = subscriptionId;
    }

    public async Task<Subscription> GetSubscriptionAsync(SubscriptionGetOptions? options = null)
    {
        var subscriptionService = new SubscriptionService();
        return await subscriptionService.GetAsync(_subscriptionId, options, RequestOptions);
    }

    public async Task<Subscription> UpdateSubscriptionAsync( SubscriptionUpdateOptions options)
    {
        var subscriptionService = new SubscriptionService();
        return await subscriptionService.UpdateAsync(_subscriptionId, options, RequestOptions);
    }

    public async Task<bool> CancelSubscriptionAsync( SubscriptionCancelOptions options)
    {
        var subscriptionService = new SubscriptionService();

        var subscription = await subscriptionService.CancelAsync(_subscriptionId, options, RequestOptions);
        return subscription.Status == "canceled";
    }
}