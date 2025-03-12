using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TranslationPro.Domain.Entities;

public class Invoice : BaseEntity<Invoice>
{
    public Invoice()
    {
        Items = new List<InvoiceItem>();
        Lines = new List<InvoiceLine>();
        UsageRecordSummaries = new List<UsageRecordSummary>();
    }

    public int UserId { get; set; }
    public string Id { get; set; } = null!;
    public ICollection<InvoiceItem> Items { get; set; }
    public ICollection<InvoiceLine> Lines { get; set; }
    public ICollection<UsageRecordSummary> UsageRecordSummaries { get; set; }
    public string SubscriptionId { get; set; } = null!;
    public Subscription Subscription { get; set; } = null!;
    public long AmountDue { get; set; }
    public long AmountPaid { get; set; }
    public bool Attempted { get; set; }
    public long AmountRemaining { get; set; }
    public long AttemptCount { get; set; }
    public string BillingReason { get; set; } = null!;
    public string CollectionMethod { get; set; } = null!;
    public string Description { get; set; } = null!;
    public DateTime? DueDate { get; set; }
    public DateTime? EffectiveAt { get; set; }
    public long? EndingBalance { get; set; }
    public string ChargeId { get; set; } = null!;
    public Charge Charge { get; set; } = null!;
    public DateTime Created { get; set; }
    public string HostedInvoiceUrl { get; set; } = null!;
    public string InvoicePdf { get; set; } = null!;
    public string Number { get; set; } = null!;
    public DateTime? NextPaymentAttempt { get; set; }
    public DateTime PeriodStart { get; set; }
    public DateTime PeriodEnd { get; set; }
    public bool Paid { get; set; }
    public string Status { get; set; } = null!;
    public long Subtotal { get; set; }
    public long? SubtotalExcludingTax { get; set; }
    public long? Tax { get; set; }
    public string ReceiptNumber { get; set; } = null!;
    public long Total { get; set; }
    public bool AutoAdvance { get; set; }
    public string Currency { get; set; } = null!;

    public override void Configure(EntityTypeBuilder<Invoice> builder)
    {
        builder.ToTable(nameof(Invoice), "Stripe");
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Subscription).WithMany(x => x.Invoices).HasForeignKey(x => x.UserId);

        builder.HasOne(x => x.Charge).WithMany(x => x.Invoices).HasForeignKey(x => x.ChargeId);
    }
}