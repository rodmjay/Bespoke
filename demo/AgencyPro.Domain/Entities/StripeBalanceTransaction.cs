namespace AgencyPro.Domain.Entities
{
    public class StripeBalanceTransaction : BaseEntity<StripeBalanceTransaction>
    {
        public string Id { get; set; }
        public string TransactionType { get; set; }
        public string Status { get; set; }

        public decimal Gross { get; set; }
        public decimal Net { get; set; }
        public decimal Fee { get; set; }
      
        public string Description { get; set; }
        public DateTime AvailableOn { get; set; }
        public bool IsDeleted { get; set; }

        public string PayoutId { get; set; }
        public StripePayout Payout { get; set; }
        public override void Configure(EntityTypeBuilder<StripeBalanceTransaction> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.HasQueryFilter(x => x.IsDeleted == false);

            builder.HasOne(x => x.Payout)
                .WithMany(x => x.BalanceTransactions)
                .HasForeignKey(x => x.PayoutId)
                .IsRequired(false);
        }
    }
}