#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using TechValley.Core.Helpers;
using TechValley.Payments.Stripe.Builders;

namespace TechValley.Payments.Stripe.Extensions;

public static class StripePaymentsBuilderExtensions
{
    public static void UseWebhooks(this StripePaymentsBuilder builder)
    {
        var settings =
            (builder.Configuration, builder.Services).ConfigureSettings<StripeWebHookSettings>(
                "StripeSettings:WebHooks");
        
        // configure webhooks here...
    }
}