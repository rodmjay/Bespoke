using Bespoke.Core.Helpers;
using Bespoke.Payments.Stripe.Builders;

namespace Bespoke.Payments.Stripe.Extensions;

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