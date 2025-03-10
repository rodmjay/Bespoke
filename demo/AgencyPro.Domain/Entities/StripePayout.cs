namespace AgencyPro.Domain.Entities
{
    public class StripePayout : BaseEntity<StripePayout>
    {
        public string Id { get; set; }
        public decimal Amount { get; set; }
        public DateTimeOffset ArrivalDate { get; set; }
        public bool Automatic { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<StripeBalanceTransaction> BalanceTransactions { get; set; }
        public override void Configure(EntityTypeBuilder<StripePayout> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.HasQueryFilter(x => x.IsDeleted == false);

            


            builder.HasMany(x => x.BalanceTransactions)
                .WithOne(x => x.Payout)
                .HasForeignKey(x => x.PayoutId)
                .IsRequired(false);
        }
    }
}