namespace AgencyPro.Domain.Entities
{
    public class StripeSource : BaseEntity<StripeSource>
    {
        public string Id { get; set; } = null!;
        public string ClientSecret { get; set; } = null!;
        public string Flow { get; set; } = null!;

        public string CustomerId { get; set; } = null!;
        public BuyerAccount Customer { get; set; }

        public string Type { get; set; } = null!;
        public string Status { get; set; } = null!;
        public bool IsDeleted { get; set; }
        public long? Amount { get; set; }
        public override void Configure(EntityTypeBuilder<StripeSource> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.HasQueryFilter(x => x.IsDeleted == false);

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.PaymentSources)
                .HasForeignKey(x => x.CustomerId)
                .IsRequired(false);

            
        }
    }
}
