#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

#nullable enable

namespace Bespoke.Payments.Stripe.Services;

public class StripeRefundService :StripeClient
{
    public StripeRefundService(string? connectId) : base(connectId)
    {
    }
}