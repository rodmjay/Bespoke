namespace AgencyPro.Domain.Entities
{
    public class StripeInvoiceLine : BaseEntity<StripeInvoiceLine>, IStripeInvoiceLine
    {
        public string Id { get; set; } = null!;
        public string InvoiceId { get; set; } = null!;
        public StripeInvoice Invoice { get; set; }
        public string Description { get; set; } = null!;
        public bool Discountable { get; set; }
        public DateTime? PeriodStart { get; set; }
        public DateTime? PeriodEnd { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; } = null!;
        public string InvoiceItemId { get; set; } = null!;

        public StripeInvoiceItem InvoiceItem { get; set; }

        public string SubscriptionId { get; set; } = null!;
        public string Type { get; set; } = null!;

        public override void Configure(EntityTypeBuilder<StripeInvoiceLine> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.HasOne(x => x.Invoice)
                .WithMany(x => x.Lines)
                .HasForeignKey(x => x.InvoiceId)
                .IsRequired();

            builder.HasOne(x => x.InvoiceItem)
                .WithMany(x => x.InvoiceLines)
                .HasForeignKey(x => x.InvoiceItemId)
                .IsRequired(false);

            
        }
    }
}
