﻿#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Stripe;
using Bespoke.Payments.Stripe.Interfaces;
using Bespoke.Shared.Common;

#nullable enable

namespace Bespoke.Payments.Stripe.Services;

using Stripe;
using System.Threading.Tasks;

public class StripeChargeClient : IStripeChargeClient
{
    private readonly string _chargeId;

    public StripeChargeClient(string chargeId)
    {
        _chargeId = chargeId;
    }
    
    public async Task<Refund> RefundChargeAsync(long? amount = null)
    {
        var refundService = new RefundService();
        var refund = await refundService.CreateAsync(new RefundCreateOptions
        {
            Charge = _chargeId,
            Amount = amount,
        });

        return refund;
    }

    public Task<Charge> UpdateCharge(ChargeUpdateOptions options)
    {
        throw new NotImplementedException();
    }

    public Task<Charge> CaptureCharge(ChargeCaptureOptions options)
    {
        throw new NotImplementedException();
    }
}
