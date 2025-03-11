#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TranslationPro.Domain.Entities;

public class InvoiceItem : BaseEntity<InvoiceItem>
{
    public string Id { get; set; } = null!;
    public string InvoiceId { get; set; } = null!;
    public Invoice Invoice { get; set; } = null!;
    public ICollection<UsageRecordSummary> UsageRecords { get; set; } =new List<UsageRecordSummary>();

    public override void Configure(EntityTypeBuilder<InvoiceItem> builder)
    {
        builder.ToTable(nameof(InvoiceItem), "Stripe");
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Invoice).WithMany(x => x.Items).HasForeignKey(x => x.InvoiceId);
    }
}