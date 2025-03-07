using Microsoft.Extensions.DependencyInjection;
using Stripe;
using TechValley.Core.Helpers;
using TechValley.Payments.Stripe.Builders;
using TechValley.Payments.Stripe.Factories;
using TechValley.Payments.Stripe.Interfaces;

namespace TechValley.Payments.Stripe.Extensions
{
    public static class PaymentsBuilderExtensions
    {
        public static PaymentsBuilder AddStripe(this PaymentsBuilder builder, Action<StripePaymentsBuilder>? build = default)
        {
            var stripeSettings = (builder.Configuration, builder.Services)
                .ConfigureSettings<StripeSettings>("PaymentSettings:Stripe");
            
            var paymentsBuilder = new StripePaymentsBuilder(builder);

            StripeConfiguration.ApiKey = stripeSettings.ApiKey;

            if (stripeSettings.UseStripeConnect)
            {
                builder.Services.AddSingleton<IStripeConnectFactory, StripeConnectFactory>();
            }
            builder.Services.AddSingleton<IStripeFactory, StripeFactory>();
            
            build?.Invoke(paymentsBuilder);

            return builder;
        }

    }
}
