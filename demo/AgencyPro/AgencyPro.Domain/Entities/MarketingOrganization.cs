﻿namespace AgencyPro.Domain.Entities;

public class MarketingOrganization : BaseEntity<MarketingOrganization>, IMarketingOrganization
{
    [ForeignKey("Id")] public Organization Organization { get; set; }

    public bool Discoverable { get; set; }

    public ICollection<Contract> MarketerContracts { get; set; }
    public OrganizationMarketer DefaultOrganizationMarketer { get; set; }

    public ICollection<MarketingAgreement> MarketingAgreements { get; set; }

    public decimal CombinedMarketingStream
    {
        get => MarketerStream + MarketingAgencyStream;
        set { }
    }

    public decimal CombinedMarketingBonus
    {
        get => MarketerBonus + MarketingAgencyBonus + ServiceFeePerLead;
        set { }
    }

    public Guid Id { get; set; }

    public decimal MarketerStream { get; set; }
    public decimal MarketingAgencyStream { get; set; }
    public decimal MarketerBonus { get; set; }
    public decimal MarketingAgencyBonus { get; set; }

    public decimal ServiceFeePerLead { get; set; }
    public Guid DefaultMarketerId { get; set; }


    public override void Configure(EntityTypeBuilder<MarketingOrganization> builder)
    {
        builder
            .HasOne(x => x.Organization)
            .WithOne(x => x.MarketingOrganization)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(x => x.MarketerContracts)
            .WithOne(x => x.MarketerOrganization)
            .HasForeignKey(x => x.MarketerOrganizationId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(x => x.MarketerStream).HasColumnType("Money");
        builder.Property(x => x.MarketingAgencyStream).HasColumnType("Money");
        builder.Property(x => x.MarketerBonus).HasColumnType("Money");
        builder.Property(x => x.MarketingAgencyBonus).HasColumnType("Money");

        builder.HasOne(x => x.DefaultOrganizationMarketer)
            .WithMany(x => x.OrganizationDefaults)
            .HasForeignKey(x => new
            {
                x.Id,
                DefaultOrganizationMarketerId = x.DefaultMarketerId
            }).IsRequired();

        builder.HasMany(x => x.MarketingAgreements)
            .WithOne(x => x.MarketingOrganization)
            .HasForeignKey(x => x.MarketingOrganizationId)
            .IsRequired();

        builder.Property(x => x.CombinedMarketingStream).HasComputedColumnSql(
            $@"[{nameof(MarketerStream)}]+[{nameof(MarketingAgencyStream)}]");

        builder.Property(x => x.CombinedMarketingBonus).HasComputedColumnSql(
            $@"[{nameof(MarketerBonus)}]+[{nameof(MarketingAgencyBonus)}]+[{nameof(ServiceFeePerLead)}]");


        //builder.Ignore(x => x.CombinedMarketingStream);

        //builder.Ignore(x => x.CombinedMarketingBonus);
    }
}