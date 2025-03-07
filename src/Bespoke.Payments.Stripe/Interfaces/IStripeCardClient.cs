#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using Stripe;
using Bespoke.Shared.Common;

namespace Bespoke.Payments.Stripe.Interfaces;

public interface IStripeCardClient
{
    Task<Card> UpdateCard(string customerId, CardUpdateOptions options);
    Task<Card> DeleteCard(string customerId, CardDeleteOptions options);
}