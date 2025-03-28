﻿namespace AgencyPro.Shared.Models;

[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
public class TransferOutput : IStripeTransfer
{
    public string InvoiceId { get; set; }

    public bool IndividualTransfer { get; set; }
    public bool OrganizationTransfer => !IndividualTransfer;
    public string RecipientName { get; set; }
    public string OrganizationName { get; set; }
    public DateTimeOffset Created { get; set; }
    public string Id { get; set; }
    public decimal Amount { get; set; }
    public decimal AmountReversed { get; set; }
    public string Description { get; set; }
    public string DestinationId { get; set; }
    public string DestinationPaymentId { get; set; }
}