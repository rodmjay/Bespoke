﻿namespace AgencyPro.Domain.Entities;

public class Recruiter : BaseEntity<Recruiter>, IRecruiter
{
    [ForeignKey("Id")] public Person Person { get; set; }

    public ICollection<OrganizationRecruiter> OrganizationRecruiters { get; set; }
    public ICollection<Contract> Contracts { get; set; }
    public ICollection<Contractor> Contractors { get; set; }
    public ICollection<Candidate> Candidates { get; set; }
    public ICollection<TimeEntry> TimeEntries { get; set; }

    public Guid Id { get; set; }
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset Updated { get; set; }

    public override void Configure(EntityTypeBuilder<Recruiter> builder)
    {
        builder
            .HasOne(x => x.Person)
            .WithOne(x => x.Recruiter);
    }
}