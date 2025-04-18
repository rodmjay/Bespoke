﻿namespace AgencyPro.Domain.Entities;

public class InvoiceTransfer : BaseEntity<InvoiceTransfer>
{
    public string TransferId { get; set; } = null!;
    public StripeTransfer Transfer { get; set; }

    public string InvoiceId { get; set; } = null!;
    public StripeInvoice Invoice { get; set; }

    public ICollection<IndividualPayoutIntent> IndividualPayoutIntents { get; set; }
    public ICollection<OrganizationPayoutIntent> OrganizationPayoutIntents { get; set; }

    public override void Configure(EntityTypeBuilder<InvoiceTransfer> builder)
    {
        builder.HasKey(x => x.TransferId);
        builder.HasOne(x => x.Transfer)
            .WithOne(x => x.InvoiceTransfer)
            .HasForeignKey<InvoiceTransfer>(x => x.TransferId)
            .IsRequired(false);

        builder.HasOne(x => x.Invoice)
            .WithMany(x => x.InvoiceTransfers)
            .HasForeignKey(x => x.InvoiceId)
            .IsRequired(false);

        builder.HasMany(x => x.IndividualPayoutIntents)
            .WithOne(x => x.InvoiceTransfer)
            .HasForeignKey(x => x.InvoiceTransferId)
            .IsRequired(false);

        builder.HasMany(x => x.OrganizationPayoutIntents)
            .WithOne(x => x.InvoiceTransfer)
            .HasForeignKey(x => x.InvoiceTransferId)
            .IsRequired(false);
    }
}