﻿namespace AgencyPro.Domain.Entities;

public class RecruitingOrganization : BaseEntity<RecruitingOrganization>, IRecruitingOrganization
{
    public Guid Id { get; set; }
    [ForeignKey("Id")] public Organization Organization { get; set; }

    public ICollection<Contract> RecruiterContracts { get; set; }
    public ICollection<RecruitingAgreement> RecruitingAgreements { get; set; }
    public decimal RecruiterBonus { get; set; }
    public decimal RecruitingAgencyBonus { get; set; }

    public bool Discoverable { get; set; }

    public decimal ServiceFeePerLead { get; set; }
    public OrganizationRecruiter DefaultOrganizationRecruiter { get; set; }

    public decimal CombinedRecruitingStream
    {
        get => RecruiterStream + RecruitingAgencyStream;
        set { }
    }

    public decimal CombinedRecruitingBonus
    {
        get => RecruiterBonus + RecruitingAgencyBonus + ServiceFeePerLead;
        set { }
    }


    public decimal RecruiterStream { get; set; }
    public decimal RecruitingAgencyStream { get; set; }


    public Guid DefaultRecruiterId { get; set; }
    //public OrganizationJoinSettings ProviderEngagementSettings { get; set; }
    //public decimal CombinedRecruitingStream
    //{
    //    get => RecruiterStream + RecruitingAgencyStream;
    //    set
    //    {

    //    }
    //}
    public override void Configure(EntityTypeBuilder<RecruitingOrganization> builder)
    {
        builder
            .HasOne(x => x.Organization)
            .WithOne(x => x.RecruitingOrganization)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(x => x.RecruiterContracts)
            .WithOne(x => x.RecruiterOrganization)
            .HasForeignKey(x => x.RecruiterOrganizationId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(x => x.RecruiterStream).HasColumnType("Money");


        builder.Property(x => x.RecruitingAgencyStream).HasColumnType("Money");
        builder.Property(x => x.RecruiterBonus).HasColumnType("Money");
        builder.Property(x => x.RecruitingAgencyBonus).HasColumnType("Money");


        builder.HasOne(x => x.DefaultOrganizationRecruiter)
            .WithMany(x => x.RecruitingOrganizationDefaults)
            .HasForeignKey(x => new
            {
                x.Id,
                DefaultOrganizationRecruiterId = x.DefaultRecruiterId
            }).IsRequired();

        builder.HasMany(x => x.RecruitingAgreements)
            .WithOne(x => x.RecruitingOrganization)
            .HasForeignKey(x => x.RecruitingOrganizationId);

        builder.Property(x => x.CombinedRecruitingStream).HasComputedColumnSql(
            $@"[{nameof(RecruiterStream)}]+[{nameof(RecruitingAgencyStream)}]");

        builder.Property(x => x.CombinedRecruitingBonus).HasComputedColumnSql(
            $@"[{nameof(RecruiterBonus)}]+[{nameof(RecruitingAgencyBonus)}]+[{nameof(ServiceFeePerLead)}]");
    }
}