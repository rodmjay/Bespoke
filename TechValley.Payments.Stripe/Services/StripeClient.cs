#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Stripe;

namespace TechValley.Payments.Stripe.Services;

public abstract class StripeClient
{
    protected RequestOptions RequestOptions { get; }

    protected StripeClient(string? connectId)
    {
        if (connectId == null)
        {
            RequestOptions = new RequestOptions();
        }
        else
        {
            RequestOptions = new RequestOptions()
            {
                StripeAccount = connectId
            };
        }
    }
}