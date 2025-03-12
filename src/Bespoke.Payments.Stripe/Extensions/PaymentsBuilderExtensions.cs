#nullable enable

using Bespoke.Core.Helpers;
using Bespoke.Payments.Stripe.Builders;
using Bespoke.Payments.Stripe.Factories;
using Bespoke.Payments.Stripe.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Stripe;

namespace Bespoke.Payments.Stripe.Extensions;

public static class PaymentsBuilderExtensions
{
    public static PaymentsBuilder AddStripe(this PaymentsBuilder builder,
        Action<StripePaymentsBuilder>? build = default)
    {
        var stripeSettings = (builder.Configuration, builder.Services)
            .ConfigureSettings<StripeSettings>("PaymentSettings:Stripe");

        var paymentsBuilder = new StripePaymentsBuilder(builder);

        StripeConfiguration.ApiKey = stripeSettings.ApiKey;

        if (stripeSettings.UseStripeConnect)
            builder.Services.AddSingleton<IStripeConnectFactory, StripeConnectFactory>();
        builder.Services.AddSingleton<IStripeFactory, StripeFactory>();

        build?.Invoke(paymentsBuilder);

        return builder;
    }
}