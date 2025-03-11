namespace AgencyPro.Domain.Entities
{
    public class StripeCheckoutSession : BaseEntity<StripeCheckoutSession>
    {
        public string Id { get; set; } = null!;
        public BuyerAccount Customer { get; set; }
        public string CustomerId { get; set; } = null!;
        public bool IsDeleted { get; set; }
        public override void Configure(EntityTypeBuilder<StripeCheckoutSession> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.HasQueryFilter(x => x.IsDeleted == false);

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.CheckoutSessions)
                .HasForeignKey(x => x.CustomerId)
                .IsRequired();

            
        }
    }
}
