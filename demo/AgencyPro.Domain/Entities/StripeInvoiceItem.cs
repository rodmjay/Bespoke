namespace AgencyPro.Domain.Entities
{
    public class StripeInvoiceItem : BaseEntity<StripeInvoiceItem>, IStripeInvoiceItem
    {
        public StripeInvoiceItem()
        {

            this.TimeEntries = new List<TimeEntry>();
            this.InvoiceLines = new List<StripeInvoiceLine>();
            this.IndividualPayoutIntents = new List<IndividualPayoutIntent>();
            this.OrganizationPayoutIntents = new List<OrganizationPayoutIntent>();
        }

        public string Id { get; set; } = null!;
        public decimal Amount { get; set; }

        public string CustomerId { get; set; } = null!;
        public BuyerAccount Customer { get; set; }

        public string Description { get; set; } = null!;

        public string InvoiceId { get; set; } = null!;
        public StripeInvoice Invoice { get; set; }
        
        public int Quantity { get; set; }
        public bool IsDeleted { get; set; }

        public DateTime? PeriodStart { get; set; }
        public DateTime? PeriodEnd { get; set; }

        public ICollection<TimeEntry> TimeEntries { get; set; }
        public ICollection<StripeInvoiceLine> InvoiceLines { get; set; }
        public ICollection<IndividualPayoutIntent> IndividualPayoutIntents { get; set; }
        public ICollection<OrganizationPayoutIntent> OrganizationPayoutIntents { get; set; }


        public Guid? ContractId { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
        public Contract Contract { get; set; }
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
}
