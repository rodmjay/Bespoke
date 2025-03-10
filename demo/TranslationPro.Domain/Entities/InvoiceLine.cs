#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TranslationPro.Domain.Entities;

public class InvoiceLine : BaseEntity<InvoiceLine>
{
    public string Id { get; set; } = null!;
    public string InvoiceId { get; set; } = null!;
    public Invoice Invoice { get; set; } = null!;
    public long Amount { get; set; }
    public long? AmountExcludingTax { get; set; } = null!;  
    public string Currency { get; set; } = null!;
    public string Description { get; set; } = null!;
    public DateTime PeriodEnd { get; set; }
    public DateTime PeriodStart { get; set; }
    public string Type { get; set; } = null!;
    public long? Quantity { get; set; } = null!;
    public decimal? UnitAmountExcludingTax { get; set; } = null!;

    public override void Configure(EntityTypeBuilder<InvoiceLine> builder)
    {
        builder.ToTable(nameof(InvoiceLine), "Stripe");
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Invoice).WithMany(x => x.Lines).HasForeignKey(x => x.InvoiceId);

    }
}