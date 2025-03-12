namespace AgencyPro.Domain.Entities;

public sealed class StripeInvoice : BaseEntity<StripeInvoice>, IInvoice
{
    public StripeInvoice()
    {
        Items = new List<StripeInvoiceItem>();
        Lines = new List<StripeInvoiceLine>();
        InvoiceTransfers = new List<InvoiceTransfer>();
        IndividualPayoutIntents = new List<IndividualPayoutIntent>();
        OrganizationPayoutIntents = new List<OrganizationPayoutIntent>();
    }

    public ProjectInvoice ProjectInvoice { get; set; }

    public string SubscriptionId { get; set; } = null!;
    public StripeSubscription SubscriptionInvoice { get; set; }
    public ICollection<StripeInvoiceItem> Items { get; set; }
    public bool IsDeleted { get; set; }

    public string StripePaymentIntentId { get; set; } = null!;
    public StripePaymentIntent PaymentIntent { get; set; }

    public string CustomerId { get; set; } = null!;
    public BuyerAccount BuyerAccount { get; set; }

    public ICollection<StripeInvoiceLine> Lines { get; set; }
    public ICollection<InvoiceTransfer> InvoiceTransfers { get; set; }
    public ICollection<StripeCharge> Charges { get; set; }
    public ICollection<IndividualPayoutIntent> IndividualPayoutIntents { get; set; }
    public ICollection<OrganizationPayoutIntent> OrganizationPayoutIntents { get; set; }


    public string Id { get; set; } = null!;

    public decimal AmountPaid { get; set; }
    public decimal AmountRemaining { get; set; }
    public decimal AmountDue { get; set; }
    public decimal AttemptCount { get; set; }
    public bool Attempted { get; set; }
    public bool AutomaticCollection { get; set; }
    public string BillingReason { get; set; } = null!;
    public DateTimeOffset? DueDate { get; set; }
    public decimal EndingBalance { get; set; }
    public string HostedInvoiceUrl { get; set; } = null!;
    public string InvoicePdf { get; set; } = null!;

    public string Status { get; set; } = null!;
    public string Number { get; set; } = null!;

    public decimal Total { get; set; }
    public decimal Subtotal { get; set; }

    public override void Configure(EntityTypeBuilder<StripeInvoice> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired();

        builder.HasQueryFilter(x => x.IsDeleted == false);

        builder.Property(x => x.Total).HasColumnType("Money");
        builder.Property(x => x.Subtotal).HasColumnType("Money");
        builder.Property(x => x.AmountRemaining).HasColumnType("Money");
        builder.Property(x => x.AmountDue).HasColumnType("Money");
        builder.Property(x => x.AmountPaid).HasColumnType("Money");

        builder.HasOne(x => x.BuyerAccount)
            .WithMany(x => x.Invoices)
            .HasForeignKey(x => x.CustomerId);

        builder.HasMany(x => x.Items)
            .WithOne(x => x.Invoice)
            .HasForeignKey(x => x.InvoiceId);

        builder.HasOne(x => x.PaymentIntent)
            .WithOne(x => x.StripeInvoice)
            .HasForeignKey<StripePaymentIntent>(x => x.InvoiceId);

        builder.HasOne(x => x.ProjectInvoice)
            .WithOne(x => x.Invoice)
            .HasForeignKey<ProjectInvoice>(x => x.InvoiceId);

        builder.HasOne(x => x.SubscriptionInvoice)
            .WithMany(x => x.Invoices)
            .HasForeignKey(x => x.SubscriptionId);

        builder.HasMany(x => x.Lines)
            .WithOne(x => x.Invoice)
            .HasForeignKey(x => x.InvoiceId)
            .IsRequired(false);

        builder.HasMany(x => x.Charges)
            .WithOne(x => x.Invoice)
            .HasForeignKey(x => x.InvoiceId)
            .IsRequired(false);

        builder.HasMany(x => x.IndividualPayoutIntents)
            .WithOne(x => x.Invoice)
            .HasForeignKey(x => x.InvoiceId)
            .IsRequired(false);

        builder.HasMany(x => x.OrganizationPayoutIntents)
            .WithOne(x => x.Invoice)
            .HasForeignKey(x => x.InvoiceId)
            .IsRequired(false);
    }
}