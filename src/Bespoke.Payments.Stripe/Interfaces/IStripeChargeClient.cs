#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Stripe;
using Bespoke.Shared.Common;

namespace Bespoke.Payments.Stripe.Interfaces;

public interface IStripeChargeClient
{
    Task<Refund> RefundChargeAsync(long? amount = null);
    Task<Charge> UpdateCharge(ChargeUpdateOptions options);
    Task<Charge> CaptureCharge(ChargeCaptureOptions options);
}