﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using Bespoke.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TranslationPro.Domain.Entities;

public class UsageRecord : BaseEntity<UsageRecord>
{
    public string Id { get; set; }
    public string SubscriptionItemId { get; set; }
    public SubscriptionItem SubscriptionsItem { get; set; }

    public ICollection<ApplicationPhrase> Phrases { get; set; }
    public ICollection<ApplicationTranslation> Translations { get; set; }
    public long Quantity { get; set; }
    public DateTime Timestamp { get; set; }

    public override void Configure(EntityTypeBuilder<UsageRecord> builder)
    {
        builder.ToTable(nameof(UsageRecord), "Stripe");
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.SubscriptionsItem).WithMany(x => x.UsageRecords).HasForeignKey(x => x.SubscriptionItemId);
    }
}

[ExcludeFromCodeCoverage]
public class ApplicationPhrase : BaseEntity<ApplicationPhrase>, ISoftDelete, ICreated
{
    public ApplicationPhrase()
    {
        Translations = new List<ApplicationTranslation>();
    }

    public Guid ApplicationId { get; set; }
    public ICollection<ApplicationTranslation> Translations { get; set; }
    public int Id { get; set; }
    public string Text { get; set; }


    public string UsageRecordId { get; set; }
    public UsageRecord UsageRecord { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public int ActualLength { get; set; }

    public DateTimeOffset CreatedOn { get; set; }

    public bool IsDeleted { get; set; }

    public override void Configure(EntityTypeBuilder<ApplicationPhrase> builder)
    {
        builder.ToTable(nameof(ApplicationPhrase), "TranslationPro");

        builder.HasKey(t => new { t.ApplicationId, t.Id });

        builder.HasOne(x => x.UsageRecord).WithMany(x => x.Phrases).HasForeignKey(x => x.UsageRecordId);

        builder.Property(x => x.ActualLength)
            .HasComputedColumnSql(
                "CASE WHEN TranslationPro.IsAscii([Text]) = 1 THEN IIF([Text] is not null, CAST(LEN([Text]) AS INT), 0) ELSE IIF([Text] is not null, CAST(DATALENGTH([Text]) AS INT), 0) END");

        builder.HasQueryFilter(x => !x.IsDeleted);
    }
}