#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using AutoMapper;
using Stripe;
using TechValley.Payments.Stripe.Interfaces;
using TechValley.Shared.Common;

namespace TechValley.Payments.Stripe.Services;

public class StripeCardClient : StripeClient, IStripeCardClient
{
    private readonly string _cardId;

    public StripeCardClient(string cardId, string? connectId = null) : base(connectId)
    {
        _cardId = cardId;
    }

    public async Task<Card> UpdateCard(string customerId, CardUpdateOptions options)
    {
        throw new NotImplementedException();
    }

    public async Task<Card> DeleteCard(string customerId, CardDeleteOptions options)
    {
        throw new NotImplementedException();
    }
}