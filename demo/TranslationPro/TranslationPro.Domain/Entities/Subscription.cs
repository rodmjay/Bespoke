#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TranslationPro.Domain.Entities;

public class Subscription : BaseEntity<Subscription>
{
    public Subscription()
    {
        Items = new List<SubscriptionItem>();
        Invoices = new List<Invoice>();
    }

    public int UserId { get; set; }

    public ICollection<SubscriptionItem> Items { get; set; }
    public ICollection<Invoice> Invoices { get; set; }
    public string CustomerId { get; set; }
    public string SubscriptionId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndedAt { get; set; }
    public long? DaysUntilDue { get; set; }
    public DateTime CurrentPeriodStart { get; set; }
    public DateTime CurrentPeriodEnd { get; set; }
    public DateTime Created { get; set; }
    public string CollectionMethod { get; set; }
    public DateTime? CanceledAt { get; set; }
    public bool CancelAtPeriodEnd { get; set; }
    public DateTime? CancelAt { get; set; }
    public override void Configure(EntityTypeBuilder<Subscription> builder)
    {
        builder.ToTable(nameof(Subscription), "Stripe");

        builder.HasKey(x => x.UserId);

    }
}