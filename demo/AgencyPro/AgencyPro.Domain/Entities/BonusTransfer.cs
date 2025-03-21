﻿namespace AgencyPro.Domain.Entities;

public class BonusTransfer : BaseEntity<BonusTransfer>
{
    public string TransferId { get; set; } = null!;
    public StripeTransfer Transfer { get; set; }

    public ICollection<IndividualBonusIntent> IndividualBonusIntents { get; set; }
    public ICollection<OrganizationBonusIntent> OrganizationBonusIntents { get; set; }

    public override void Configure(EntityTypeBuilder<BonusTransfer> builder)
    {
        builder.HasKey(x => x.TransferId);
        builder.HasOne(x => x.Transfer)
            .WithOne(x => x.BonusTransfer)
            .HasForeignKey<BonusTransfer>(x => x.TransferId)
            .IsRequired(false);

        builder.HasMany(x => x.IndividualBonusIntents)
            .WithOne(x => x.BonusTransfer)
            .HasForeignKey(x => x.TransferId)
            .IsRequired(false);

        builder.HasMany(x => x.OrganizationBonusIntents)
            .WithOne(x => x.BonusTransfer)
            .HasForeignKey(x => x.TransferId)
            .IsRequired(false);
    }
}