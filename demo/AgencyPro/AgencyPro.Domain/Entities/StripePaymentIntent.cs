namespace AgencyPro.Domain.Entities
{
    public class StripePaymentIntent : BaseEntity<StripePaymentIntent>, IStripePaymentIntent
    {
        public string Id { get; set; } = null!;
        public decimal? Amount { get; set; }
        public decimal? AmountCapturable { get; set; }
        public decimal? AmountReceived { get; set; }
        public DateTime? CancelledAt { get; set; }
        public string CaptureMethod { get; set; } = null!;

        public ICollection<StripeCharge> Charges { get; set; }

        public string InvoiceId { get; set; } = null!;
        public StripeInvoice StripeInvoice { get; set; }

        public string ConfirmationMethod { get; set; } = null!;
        public string CustomerId { get; set; } = null!;
        public string TransferGroup { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
        public bool IsDeleted { get; set; }
        public override void Configure(EntityTypeBuilder<StripePaymentIntent> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.HasQueryFilter(x => x.IsDeleted == false);

            builder.HasMany(x => x.Charges)
                .WithOne(x => x.PaymentIntent)
                .HasForeignKey(x => x.PaymentIntentId);

            builder.HasOne(x => x.StripeInvoice)
                .WithOne(x => x.PaymentIntent)
                .HasForeignKey<StripePaymentIntent>(x => x.InvoiceId);

        }
    }
}
