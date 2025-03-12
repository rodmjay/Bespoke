using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TranslationPro.Domain.Entities;

public class Charge : BaseEntity<Charge>
{
    public string Id { get; set; } = null!;
    public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public override void Configure(EntityTypeBuilder<Charge> builder)
    {
        builder.ToTable(nameof(Charge), "Stripe");
        builder.HasKey(e => e.Id);
    }
}