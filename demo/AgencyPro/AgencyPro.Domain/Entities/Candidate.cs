﻿namespace AgencyPro.Domain.Entities;

public class Candidate : BaseEntity<Candidate>, ICandidate
{
    public OrganizationRecruiter OrganizationRecruiter { get; set; } = null!;
    public OrganizationProjectManager OrganizationProjectManager { get; set; } = null!;
    public ProviderOrganization ProviderOrganization { get; set; } = null!;
    public ICollection<Comment> Comments { get; set; } = null!;

    public ICollection<CandidateNotification> CandidateNotifications { get; set; } = null!;

    public string Iso2 { get; set; } = null!;
    public string ProvinceState { get; set; } = null!;
    public Recruiter Recruiter { get; set; } = null!;

    public Organization RecruiterOrganization { get; set; } = null!;
    public ProjectManager ProjectManager { get; set; } = null!;
    public bool IsDeleted { get; set; }


    public IndividualBonusIntent IndividualBonusIntent { get; set; } = null!;

    public OrganizationBonusIntent OrganizationBonusIntent { get; set; } = null!;
    public Guid ProviderOrganizationId { get; set; }

    public virtual CandidateStatus Status { get; set; }


    public Guid Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string EmailAddress { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public decimal RecruiterStream { get; set; }
    public DateTimeOffset Updated { get; set; }
    public decimal RecruiterBonus { get; set; }

    public decimal RecruitingAgencyStream { get; set; }
    public decimal RecruitingAgencyBonus { get; set; }

    public bool IsContacted { get; set; }
    public Guid RecruiterId { get; set; }
    public Guid RecruiterOrganizationId { get; set; }

    public RejectionReason RejectionReason { get; set; }
    public string RejectionDescription { get; set; } = null!;

    public Guid? ProjectManagerId { get; set; }
    public Guid? ProjectManagerOrganizationId { get; set; }

    public string Description { get; set; } = null!;

    public Guid CreatedById { get; set; }
    public Guid UpdatedById { get; set; }
    public DateTimeOffset Created { get; set; }

    public override void Configure(EntityTypeBuilder<Candidate> builder)
    {
        builder
            .HasKey(x => x.Id);
        builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");

        builder.HasOne(x => x.IndividualBonusIntent)
            .WithOne(x => x.Candidate)
            .HasForeignKey<IndividualBonusIntent>(x => x.CandidateId)
            .IsRequired(false);

        builder.HasOne(x => x.OrganizationBonusIntent)
            .WithOne(x => x.Candidate)
            .HasForeignKey<OrganizationBonusIntent>(x => x.CandidateId)
            .IsRequired(false);

        builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
        builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
        builder.Property(x => x.EmailAddress).IsRequired().HasMaxLength(254);
        builder.Property(x => x.PhoneNumber).HasMaxLength(50);
        builder.Property(x => x.RecruiterStream).HasColumnType("Money");
        builder.Property(x => x.RecruiterBonus).HasColumnType("Money");
        builder.Property(x => x.RecruitingAgencyBonus).HasColumnType("Money");
        builder.Property(x => x.RecruitingAgencyStream).HasColumnType("Money");
        builder.Property(x => x.RejectionDescription).HasMaxLength(1000);

        builder
            .Property(p => p.Iso2)
            .HasColumnType("char(2)")
            .HasMaxLength(2);

        builder.Property(p => p.ProvinceState)
            .IsRequired()
            .HasColumnType("varchar(3)")
            .HasMaxLength(3);

        builder.HasOne(x => x.Recruiter)
            .WithMany(x => x.Candidates)
            .HasForeignKey(x => x.RecruiterId)
            .IsRequired(false);

        builder.HasOne(x => x.ProjectManager)
            .WithMany(x => x.Candidates)
            .HasForeignKey(x => x.ProjectManagerId)
            .IsRequired(false);

        builder.HasQueryFilter(x => x.IsDeleted == false);

        builder.HasOne(x => x.OrganizationProjectManager)
            .WithMany(x => x.Candidates)
            .HasForeignKey(x => new
            {
                x.ProjectManagerOrganizationId,
                x.ProjectManagerId
            }).OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(x => x.ProviderOrganization)
            .WithMany(x => x.Candidates)
            .HasForeignKey(x => x.ProviderOrganizationId)
            .IsRequired(false);
    }
}