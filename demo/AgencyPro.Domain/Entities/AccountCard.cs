namespace AgencyPro.Domain.Entities
{
    public class AccountCard : BaseEntity<AccountCard>
    {
        public string Id { get; set; } = null!;

        public string AccountId { get; set; } = null!;
        public FinancialAccount FinancialAccount { get; set; }

        public StripeCard StripeCard { get; set; }
        public bool IsDeleted { get; set; }

        public string Status { get; set; } = null!;
        public string Type { get; set; } = null!;

        public override void Configure(EntityTypeBuilder<AccountCard> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.HasQueryFilter(x => x.IsDeleted == false);

            builder.HasOne(x => x.FinancialAccount)
                .WithMany(x => x.Cards)
                .HasForeignKey(x => x.AccountId)
                .IsRequired();

            builder.HasOne(x => x.StripeCard)
                .WithOne(x => x.AccountCard)
                .HasForeignKey<AccountCard>(x => x.Id);
        }
    }
}
