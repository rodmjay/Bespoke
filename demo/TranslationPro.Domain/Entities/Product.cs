using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TranslationPro.Domain.Entities;

public class Product : BaseEntity<Product>
{
    public string Id { get; set; } = null!;
    public ICollection<Plan> Plans { get; set; } = new List<Plan>();
    public string Description { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Type { get; set; } = null!;
    public ICollection<SubscriptionItem> SubscriptionItems { get; set; } = new List<SubscriptionItem>();

    public override void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable(nameof(Product), "Stripe");
        builder.HasKey(p => p.Id);
    }
}