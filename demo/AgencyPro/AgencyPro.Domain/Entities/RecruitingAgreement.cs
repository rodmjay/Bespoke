namespace AgencyPro.Domain.Entities;

public class RecruitingAgreement : BaseEntity<RecruitingAgreement>, IRecruitingAgreement
{
    public ProviderOrganization ProviderOrganization { get; set; }
    public RecruitingOrganization RecruitingOrganization { get; set; }

    public string RecruiterInformation { get; set; } = null!;


    public decimal RecruitingStream
    {
        get => RecruiterStream + RecruitingAgencyStream;
        set { }
    }

    public decimal RecruitingBonus
    {
        get => RecruiterBonus + RecruitingAgencyBonus;
        set { }
    }

    public Guid ProviderOrganizationId { get; set; }

    public Guid RecruitingOrganizationId { get; set; }

    public bool InitiatedByProvider { get; set; }

    public virtual decimal RecruiterStream { get; set; }
    public virtual decimal RecruitingAgencyBonus { get; set; }
    public virtual decimal RecruiterBonus { get; set; }
    public virtual decimal RecruitingAgencyStream { get; set; }

    public AgreementStatus Status { get; set; }

    public override void Configure(EntityTypeBuilder<RecruitingAgreement> builder)
    {
        builder.HasKey(x => new
        {
            x.ProviderOrganizationId,
            x.RecruitingOrganizationId
        });

        builder.HasOne(x => x.ProviderOrganization)
            .WithMany(x => x.RecruitingAgreements)
            .HasForeignKey(x => x.ProviderOrganizationId);

        builder.Property(x => x.RecruiterBonus).HasColumnType("Money");
        builder.Property(x => x.RecruitingAgencyBonus).HasColumnType("Money");
        builder.Property(x => x.RecruiterStream).HasColumnType("Money");
        builder.Property(x => x.RecruitingAgencyStream).HasColumnType("Money");


        var recruitingStreamComputation = $@"[{nameof(RecruitingAgencyStream)}]+[{nameof(RecruiterStream)}]";
        var recruitingBonusComputation = $@"[{nameof(RecruitingAgencyBonus)}]+[{nameof(RecruiterBonus)}]";

        builder.Property(x => x.RecruitingStream).HasComputedColumnSql(recruitingStreamComputation);
        builder.Property(x => x.RecruitingBonus).HasComputedColumnSql(recruitingBonusComputation);
    }
}