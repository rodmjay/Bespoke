namespace AgencyPro.Domain.Entities
{
    public class CustomerCard : BaseEntity<CustomerCard>
    {
        public string Id { get; set; } = null!;

        public string CustomerId { get; set; } = null!;
        public BuyerAccount Customer { get; set; }

        // Add explicit navigation property to Customer entity with correct type
        public Customer CustomerEntity { get; set; }
        public Guid? CustomerEntityId { get; set; }

        public StripeCard StripeCard { get; set; }
        public bool IsDeleted { get; set; }
        public override void Configure(EntityTypeBuilder<CustomerCard> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired();

            builder.HasQueryFilter(x => x.IsDeleted == false);

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Cards)
                .HasForeignKey(x => x.CustomerId)
                .IsRequired(false);

            // Configure the relationship to Customer entity explicitly
            builder.HasOne(x => x.CustomerEntity)
                .WithMany(x => x.Cards)
                .HasForeignKey(x => x.CustomerEntityId)
                .IsRequired(false);

            builder.HasOne(x => x.StripeCard)
                .WithOne(x => x.CustomerCard)
                .HasForeignKey<CustomerCard>(x => x.Id)
                .IsRequired(false);
        }
    }
}
