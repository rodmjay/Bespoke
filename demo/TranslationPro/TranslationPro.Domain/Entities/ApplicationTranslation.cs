#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TranslationPro.Domain.Entities;

[ExcludeFromCodeCoverage]
public class ApplicationTranslation : BaseEntity<ApplicationTranslation>, ISoftDelete, ICreated
{
    public Guid ApplicationId { get; set; }
    public int PhraseId { get; set; }
    public string LanguageId { get; set; } = null!;

    public ApplicationPhrase ApplicationPhrase { get; set; } = null!;
    public ApplicationLanguage ApplicationLanguage { get; set; } = null!;
    public int MachineTranslations { get; set; }

    public string Text { get; set; } = null!;


    public string UsageRecordId { get; set; } = null!;
    public UsageRecord UsageRecord { get; set; } = null!;

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public int ActualLength { get; set; }

    public override void Configure(EntityTypeBuilder<ApplicationTranslation> builder)
    {
        builder.ToTable(nameof(ApplicationTranslation), "TranslationPro");

        builder.HasKey(x => new {x.ApplicationId, x.PhraseId, x.LanguageId});

        builder.HasOne(x => x.ApplicationPhrase)
            .WithMany(x => x.Translations)
            .HasForeignKey(x => new {x.ApplicationId, x.PhraseId});

        builder.HasOne(x => x.ApplicationLanguage)
            .WithMany(x => x.Translations)
            .HasForeignKey(x => new {x.ApplicationId, x.LanguageId})
            .OnDelete(DeleteBehavior.NoAction);


        builder.HasOne(x => x.UsageRecord).WithMany(x => x.Translations).HasForeignKey(x => x.UsageRecordId);
        
        builder.Property(x => x.ActualLength)
            .HasComputedColumnSql("CASE WHEN TranslationPro.IsAscii([Text]) = 1 THEN IIF([Text] is not null, CAST(LEN([Text]) AS INT), 0) ELSE IIF([Text] is not null, CAST(DATALENGTH([Text]) AS INT), 0) END");

    }


    public bool IsDeleted { get; set; }
    public DateTimeOffset Created { get; set; }
}