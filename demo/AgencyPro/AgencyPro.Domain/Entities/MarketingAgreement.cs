namespace AgencyPro.Domain.Entities;

public class MarketingAgreement : BaseEntity<MarketingAgreement>, IMarketingAgreement
{
    public ProviderOrganization ProviderOrganization { get; set; }
    public MarketingOrganization MarketingOrganization { get; set; }
    public bool RequireUniqueEmail { get; set; }

    public string MarketerInformation { get; set; } = null!;

    public decimal MarketingStream
    {
        get => MarketerStream + MarketingAgencyStream;
        set { }
    }

    public decimal MarketingBonus
    {
        get => MarketerBonus + MarketingAgencyBonus;
        set { }
    }

    public Guid ProviderOrganizationId { get; set; }

    public Guid MarketingOrganizationId { get; set; }


    public bool InitiatedByProvider { get; set; }

    public decimal MarketerBonus { get; set; }
    public decimal MarketingAgencyStream { get; set; }
    public decimal MarketingAgencyBonus { get; set; }
    public decimal MarketerStream { get; set; }

    public AgreementStatus Status { get; set; }

    public override void Configure(EntityTypeBuilder<MarketingAgreement> builder)
    {
        builder.HasKey(x => new
        {
            x.ProviderOrganizationId,
            x.MarketingOrganizationId
        });

        builder.HasOne(x => x.ProviderOrganization)
            .WithMany(x => x.MarketingAgreements)
            .HasForeignKey(x => x.ProviderOrganizationId);

        builder.Property(x => x.MarketerBonus).HasColumnType("Money");
        builder.Property(x => x.MarketingAgencyStream).HasColumnType("Money");
        builder.Property(x => x.MarketerStream).HasColumnType("Money");
        builder.Property(x => x.MarketingAgencyBonus).HasColumnType("Money");


        var marketingStreamComputation = $@"[{nameof(MarketingAgencyStream)}]+[{nameof(MarketerStream)}]";
        var marketingBonusComputation = $@"[{nameof(MarketerBonus)}]+[{nameof(MarketingAgencyBonus)}]";

        builder.Property(x => x.MarketingStream).HasComputedColumnSql(marketingStreamComputation);
        builder.Property(x => x.MarketingBonus).HasComputedColumnSql(marketingBonusComputation);
    }
}