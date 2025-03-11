namespace AgencyPro.Domain.Entities
{
    public class StripeCard : BaseEntity<StripeCard>, IStripeCard
    {
        public string Id { get; set; } = null!;
        public string AddressCity { get; set; } = null!;
        public string AddressCountry { get; set; } = null!;
        public string AddressLine1 { get; set; } = null!;
        public string AddressLine2 { get; set; } = null!;
      
        public string Brand { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string CvcCheck { get; set; } = null!;
        public string DynamicLast4 { get; set; } = null!;
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public string Fingerprint { get; set; } = null!;
        public string Funding { get; set; } = null!;
        public string Last4 { get; set; } = null!;
        public string Name { get; set; } = null!;
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
        public bool IsDeleted { get; set; }
       
        public CustomerCard CustomerCard { get; set; }
        public AccountCard AccountCard { get; set; }
        public override void Configure(EntityTypeBuilder<StripeCard> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasQueryFilter(x => x.IsDeleted == false);

            builder.Property(x => x.Id).IsRequired();

            builder.HasOne(x => x.AccountCard)
                .WithOne(x => x.StripeCard)
                .HasForeignKey<AccountCard>(x => x.Id);

            builder.HasOne(x => x.CustomerCard)
                .WithOne(x => x.StripeCard)
                .HasForeignKey<CustomerCard>(x => x.Id);
        }
    }
}
