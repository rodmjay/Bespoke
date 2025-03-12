using Stripe;

namespace Bespoke.Payments.Stripe.Interfaces;

public interface IStripeChargeClient
{
    Task<Refund> RefundChargeAsync(long? amount = null);
    Task<Charge> UpdateCharge(ChargeUpdateOptions options);
    Task<Charge> CaptureCharge(ChargeCaptureOptions options);
}