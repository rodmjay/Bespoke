namespace AgencyPro.Domain.Entities
{
    public class ProjectManager : BaseEntity<ProjectManager>, IProjectManager
    {
        [ForeignKey("Id")] public Person Person { get; set; }

        public ICollection<OrganizationProjectManager> OrganizationProjectManagers { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<Candidate> Candidates { get; set; }
        public ICollection<Contract> Contracts { get; set; }
        public ICollection<TimeEntry> TimeEntries { get; set; }
        public ICollection<ProjectInvoice> Invoices { get; set; }

        public Guid Id { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }


        public override void Configure(EntityTypeBuilder<ProjectManager> builder)
        {
            builder
                .HasOne(x => x.Person)
                .WithOne(x => x.ProjectManager)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}