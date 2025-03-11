namespace AgencyPro.Domain.Entities
{
    public class Contractor : BaseEntity<Contractor>, IContractor
    {
        [ForeignKey("Id")] public Person Person { get; set; }

        public OrganizationRecruiter OrganizationRecruiter { get; set; }
        public ICollection<Contract> Contracts { get; set; }
        public ICollection<Story> Stories { get; set; }
        public ICollection<TimeEntry> TimeEntries { get; set; }
        public ICollection<OrganizationContractor> OrganizationContractors { get; set; }
        public Guid Id { get; set; }

        public Guid RecruiterId { get; set; }
        public Recruiter Recruiter { get; set; }
        public Guid RecruiterOrganizationId { get; set; }

        public bool IsAvailable { get; set; }

        public DateTimeOffset Updated { get; set; }
        public int HoursAvailable { get; set; }

        public DateTime? LastWorkedUtc { get; set; }
        public DateTimeOffset Created { get; set; }

        public ICollection<ContractorSkill> ContractorSkills { get; set; }
        public override void Configure(EntityTypeBuilder<Contractor> builder)
        {
            // Comment out HasMany calls to prevent duplicate relationship definitions
            // builder
            //     .HasMany(x => x.OrganizationContractors)
            //     .WithOne(x => x.Contractor)
            //     .HasForeignKey(x => x.ContractorId);

            builder.HasOne(x => x.Recruiter)
                .WithMany(x => x.Contractors)
                .HasForeignKey(x => x.RecruiterId);

            builder.Property(x => x.HoursAvailable)
                .HasDefaultValue(40);

            
        }
    }
}
