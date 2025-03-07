#nullable enable

﻿namespace Bespoke.Payments.Stripe.Services;

public class StripeInvoiceClient : StripeClient
{
    private readonly string _invoiceId;

    public StripeInvoiceClient(string invoiceId, string? connectId) :base(connectId)
    {
        _invoiceId = invoiceId;
    }
}