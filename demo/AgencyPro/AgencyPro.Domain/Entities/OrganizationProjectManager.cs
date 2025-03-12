namespace AgencyPro.Domain.Entities;

public class OrganizationProjectManager : BaseEntity<OrganizationProjectManager>, IOrganizationProjectManager
{
    public Organization Organization { get; set; }
    public ProjectManager ProjectManager { get; set; }

    public OrganizationMembership OrganizationMembership { get; set; }

    public ICollection<ProviderOrganization> DefaultOrganizations { get; set; }
    public ICollection<Contract> Contracts { get; set; }
    public ICollection<TimeEntry> TimeEntries { get; set; }
    public ICollection<ProjectInvoice> Invoices { get; set; }

    public decimal ProjectManagerStream { get; set; }

    public ICollection<Project> Projects { get; set; }

    public ICollection<Candidate> Candidates { get; set; }

    public bool IsDeleted { get; set; }
    public string ConcurrencyStamp { get; set; } = null!;


    public Guid CreatedById { get; set; }
    public Guid UpdatedById { get; set; }
    public Guid OrganizationId { get; set; }

    public Guid ProjectManagerId { get; set; }

    public override void Configure(EntityTypeBuilder<OrganizationProjectManager> builder)
    {
        builder.HasKey(x => new { x.OrganizationId, x.ProjectManagerId });

        builder.Property(x => x.ProjectManagerStream).HasColumnType("Money");
        builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();
        builder.HasQueryFilter(x => x.IsDeleted == false);

        builder.HasOne(x => x.Organization)
            .WithMany(x => x.ProjectManagers)
            .HasForeignKey(x => x.OrganizationId);

        builder.HasMany(x => x.Projects)
            .WithOne(x => x.OrganizationProjectManager)
            .HasForeignKey(x => new { x.ProjectManagerOrganizationId, x.ProjectManagerId });

        builder.HasOne(x => x.OrganizationMembership)
            .WithOne(x => x.ProjectManager)
            .HasForeignKey<OrganizationProjectManager>(x => new { x.OrganizationId, x.ProjectManagerId })
            .OnDelete(DeleteBehavior.Cascade);
    }
}