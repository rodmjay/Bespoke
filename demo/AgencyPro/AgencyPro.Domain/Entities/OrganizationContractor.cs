namespace AgencyPro.Domain.Entities;

public class OrganizationContractor : BaseEntity<OrganizationContractor>
{
    public Guid OrganizationId { get; set; }
    public Guid ContractorId { get; set; }

    public decimal ContractorStream { get; set; }

    public OrganizationMembership OrganizationMembership { get; set; }

    public ICollection<ProviderOrganization> DefaultOrganizations { get; set; }
    public Organization Organization { get; set; }
    public Contractor Contractor { get; set; }

    public bool IsFeatured { get; set; }
    public string Biography { get; set; } = null!;
    public string PortfolioMediaUrl { get; set; } = null!;

    public ICollection<TimeEntry> TimeEntries { get; set; }
    public ICollection<Contract> Contracts { get; set; }
    public ICollection<Story> Stories { get; set; }

    public bool IsDeleted { get; set; }
    public virtual string ConcurrencyStamp { get; set; } = null!;


    public Guid CreatedById { get; set; }
    public Guid UpdatedById { get; set; }


    public bool AutoApproveTimeEntries { get; set; }

    public override void Configure(EntityTypeBuilder<OrganizationContractor> builder)
    {
        builder
            .HasKey(x => new
            {
                x.OrganizationId,
                x.ContractorId
            });

        builder.Property(x => x.ContractorStream)
            .HasColumnType("Money")
            .IsRequired();

        builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();
        builder.HasQueryFilter(x => x.IsDeleted == false);

        builder.HasOne(x => x.Organization)
            .WithMany(x => x.Contractors)
            .HasForeignKey(x => x.OrganizationId);

        // Comment out HasMany calls to prevent duplicate relationship definitions
        // builder
        //     .HasMany(x => x.Contracts)
        //     .WithOne(x => x.OrganizationContractor)
        //     .HasForeignKey(x => new
        //     {
        //         x.ContractorOrganizationId,
        //         x.ContractorId
        //     });

        // builder
        //     .HasMany(x => x.Stories)
        //     .WithOne(x => x.OrganizationContractor)
        //     .HasForeignKey(x => new
        //     {
        //         x.ContractorOrganizationId,
        //         x.ContractorId
        //     });

        builder.HasOne(x => x.OrganizationMembership)
            .WithOne(x => x.Contractor);

        builder
            .HasOne(x => x.OrganizationMembership)
            .WithOne(x => x.Contractor)
            .HasForeignKey<OrganizationContractor>(x => new
            {
                x.OrganizationId,
                x.ContractorId
            })
            .OnDelete(DeleteBehavior.Cascade);
    }
}