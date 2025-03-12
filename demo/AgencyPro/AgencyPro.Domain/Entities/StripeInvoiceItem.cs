namespace AgencyPro.Domain.Entities;

public class StripeInvoiceItem : BaseEntity<StripeInvoiceItem>, IStripeInvoiceItem
{
    public StripeInvoiceItem()
    {
        TimeEntries = new List<TimeEntry>();
        InvoiceLines = new List<StripeInvoiceLine>();
        IndividualPayoutIntents = new List<IndividualPayoutIntent>();
        OrganizationPayoutIntents = new List<OrganizationPayoutIntent>();
    }

    public BuyerAccount Customer { get; set; }
    public StripeInvoice Invoice { get; set; }
    public bool IsDeleted { get; set; }

    public ICollection<TimeEntry> TimeEntries { get; set; }
    public ICollection<StripeInvoiceLine> InvoiceLines { get; set; }
    public ICollection<IndividualPayoutIntent> IndividualPayoutIntents { get; set; }
    public ICollection<OrganizationPayoutIntent> OrganizationPayoutIntents { get; set; }
    public Contract Contract { get; set; }

    public string Id { get; set; } = null!;
    public decimal Amount { get; set; }

    public string CustomerId { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string InvoiceId { get; set; } = null!;

    public int Quantity { get; set; }

    public DateTime? PeriodStart { get; set; }
    public DateTime? PeriodEnd { get; set; }


    public Guid? ContractId { get; set; }
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset Updated { get; set; }

    public override void Configure(EntityTypeBuilder<StripeInvoiceItem> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired();

        builder.HasQueryFilter(x => x.IsDeleted == false);

        builder.HasOne(x => x.Customer)
            .WithMany(x => x.InvoiceItems)
            .HasForeignKey(x => x.CustomerId);

        builder.HasOne(x => x.Invoice)
            .WithMany(x => x.Items)
            .HasForeignKey(x => x.InvoiceId);

        builder.HasMany(x => x.TimeEntries)
            .WithOne(x => x.InvoiceItem)
            .HasForeignKey(x => x.InvoiceItemId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(x => x.Contract)
            .WithMany(x => x.InvoiceItems)
            .HasForeignKey(x => x.ContractId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasMany(x => x.IndividualPayoutIntents)
            .WithOne(x => x.InvoiceItem)
            .HasForeignKey(x => x.InvoiceItemId)
            .IsRequired();

        builder.HasMany(x => x.OrganizationPayoutIntents)
            .WithOne(x => x.InvoiceItem)
            .HasForeignKey(x => x.InvoiceItemId)
            .IsRequired();

        builder.HasMany(x => x.InvoiceLines)
            .WithOne(x => x.InvoiceItem)
            .HasForeignKey(x => x.InvoiceItemId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.SetNull);
    }
}