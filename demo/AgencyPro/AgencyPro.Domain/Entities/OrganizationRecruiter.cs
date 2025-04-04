﻿namespace AgencyPro.Domain.Entities;

public class OrganizationRecruiter : BaseEntity<OrganizationRecruiter>, IOrganizationRecruiter
{
    public Organization Organization { get; set; }
    public Recruiter Recruiter { get; set; }

    public OrganizationMembership OrganizationMembership { get; set; }

    public decimal RecruiterStream { get; set; }

    public ICollection<Contract> Contracts { get; set; }
    public ICollection<TimeEntry> TimeEntries { get; set; }

    public ICollection<Contractor> Contractors { get; set; }

    public ICollection<Candidate> Candidates { get; set; }
    public bool IsSystemDefault { get; set; }

    public bool IsDeleted { get; set; }
    public string ConcurrencyStamp { get; set; } = null!;


    public Guid CreatedById { get; set; }
    public Guid UpdatedById { get; set; }
    public ICollection<RecruitingOrganization> RecruitingOrganizationDefaults { get; set; }
    public decimal RecruiterBonus { get; set; }
    public Guid OrganizationId { get; set; }

    public Guid RecruiterId { get; set; }

    public override void Configure(EntityTypeBuilder<OrganizationRecruiter> builder)
    {
        builder
            .HasKey(x => new
            {
                x.OrganizationId,
                x.RecruiterId
            });
        builder.HasQueryFilter(x => x.IsDeleted == false);

        builder.Property(x => x.RecruiterStream).HasColumnType("Money");
        builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

        builder
            .HasMany(x => x.Contractors)
            .WithOne(x => x.OrganizationRecruiter)
            .HasForeignKey(x => new
            {
                x.RecruiterOrganizationId,
                x.RecruiterId
            })
            .IsRequired(false);

        builder
            .HasMany(x => x.Contracts)
            .WithOne(x => x.OrganizationRecruiter)
            .HasForeignKey(x => new
            {
                x.RecruiterOrganizationId,
                x.RecruiterId
            });

        builder
            .HasMany(x => x.Candidates)
            .WithOne(x => x.OrganizationRecruiter)
            .HasForeignKey(x => new
            {
                x.RecruiterOrganizationId,
                x.RecruiterId
            });

        builder
            .HasOne(x => x.OrganizationMembership)
            .WithOne(x => x.Recruiter).HasForeignKey<OrganizationRecruiter>(x => new
            {
                x.OrganizationId,
                x.RecruiterId
            })
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);
    }
}