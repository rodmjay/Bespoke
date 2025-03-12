using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TranslationPro.Domain.Entities;

[ExcludeFromCodeCoverage]
public class Language : BaseEntity<Language>
{
    public string Name { get; set; } = null!;
    public string Id { get; set; } = null!;

    public ICollection<ApplicationLanguage> Applications { get; set; } = new List<ApplicationLanguage>();

    public override void Configure(EntityTypeBuilder<Language> builder)
    {
        builder.ToTable(nameof(Language), "TranslationPro");

        builder.HasKey(x => x.Id);
    }
}