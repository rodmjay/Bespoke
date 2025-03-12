using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TranslationPro.Domain.Entities;

public class Plan : BaseEntity<Plan>
{
    public string Id { get; set; } = null!;
    public string ProductId { get; set; } = null!;
    public Product Product { get; set; } = null!;
    public bool Active { get; set; }
    public long? Amount { get; set; }
    public decimal? AmountDecimal { get; set; }
    public string Interval { get; set; } = null!;
    public long IntervalCount { get; set; }

    public ICollection<SubscriptionItem> SubscriptionItems { get; set; } = new List<SubscriptionItem>();


    public override void Configure(EntityTypeBuilder<Plan> builder)
    {
        builder.ToTable(nameof(Plan), "Stripe");
        builder.HasKey(p => p.Id);

        builder.HasOne(x => x.Product).WithMany(x => x.Plans).HasForeignKey(x => x.ProductId);
    }
}