namespace AgencyPro.Domain.Entities;

public class StripeSubscriptionItem : BaseEntity<StripeSubscriptionItem>
{
    public string Id { get; set; } = null!;
    public StripeSubscription Subscription { get; set; }
    public string SubscriptionId { get; set; } = null!;

    public string PlanId { get; set; } = null!;
    public bool IsDeleted { get; set; }
    public long Quantity { get; set; }

    public override void Configure(EntityTypeBuilder<StripeSubscriptionItem> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired();

        builder.HasOne(x => x.Subscription)
            .WithMany(x => x.Items)
            .HasForeignKey(x => x.SubscriptionId)
            .IsRequired(false);

        builder.HasQueryFilter(x => x.IsDeleted == false);
    }
}