namespace AgencyPro.Domain.Entities;

public class StripeBalanceTransaction : BaseEntity<StripeBalanceTransaction>
{
    public string Id { get; set; } = null!;
    public string TransactionType { get; set; } = null!;
    public string Status { get; set; } = null!;

    public decimal Gross { get; set; }
    public decimal Net { get; set; }
    public decimal Fee { get; set; }

    public string Description { get; set; } = null!;
    public DateTime AvailableOn { get; set; }
    public bool IsDeleted { get; set; }

    public string PayoutId { get; set; } = null!;
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