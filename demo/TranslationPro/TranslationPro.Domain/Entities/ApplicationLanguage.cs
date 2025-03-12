using Bespoke.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TranslationPro.Domain.Entities;

public class ApplicationLanguage : BaseEntity<ApplicationLanguage>, ISoftDelete
{
    public Guid ApplicationId { get; set; }

    public string LanguageId { get; set; } = null!;
    public Language Language { get; set; } = null!;

    public ICollection<ApplicationTranslation> Translations { get; set; } = new List<ApplicationTranslation>();
    public bool IsDeleted { get; set; }

    public override void Configure(EntityTypeBuilder<ApplicationLanguage> builder)
    {
        builder.ToTable(nameof(ApplicationLanguage), "TranslationPro");

        builder.HasKey(x => new { x.ApplicationId, x.LanguageId });

        builder.HasOne(x => x.Language)
            .WithMany(x => x.Applications).HasForeignKey(x => x.LanguageId);

        builder.HasQueryFilter(x => !x.IsDeleted);
    }
}