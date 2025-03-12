namespace AgencyPro.Domain.Entities;

public class ProviderOrganization : BaseEntity<ProviderOrganization>, IProviderOrganization
{
    [ForeignKey("Id")] public Organization Organization { get; set; }

    public ICollection<Contract> Contracts { get; set; }

    public ICollection<MarketingAgreement> MarketingAgreements { get; set; }
    public ICollection<RecruitingAgreement> RecruitingAgreements { get; set; }

    public ICollection<Project> Projects { get; set; }
    public ICollection<Lead> Leads { get; set; }
    public string RecruiterInformation { get; set; } = null!;
    public string MarketerInformation { get; set; } = null!;

    public bool Discoverable { get; set; }

    public OrganizationContractor DefaultContractor { get; set; }
    public OrganizationProjectManager DefaultProjectManager { get; set; }
    public OrganizationAccountManager DefaultAccountManager { get; set; }


    public ICollection<WorkOrder> WorkOrders { get; set; }

    public ICollection<Candidate> Candidates { get; set; }
    public ICollection<CustomerAccount> CustomerAccounts { get; set; }

    public bool AutoApproveTimeEntries { get; set; }


    //public ICollection<OrganizationProjectManager> ProjectManagers { get; set; }
    //public ICollection<OrganizationAccountManager> AccountManagers { get; set; }
    //public ICollection<OrganizationContractor> Contractors { get; set; }

    public ICollection<OrganizationSkill> Skills { get; set; }
    public Guid Id { get; set; }

    public decimal AccountManagerStream { get; set; }
    public decimal ProjectManagerStream { get; set; }
    public decimal AgencyStream { get; set; }

    public decimal ContractorStream { get; set; }

    public string ProviderInformation { get; set; } = null!;
    public string ProjectManagerInformation { get; set; } = null!;
    public string AccountManagerInformation { get; set; } = null!;
    public string ContractorInformation { get; set; } = null!;


    public int EstimationBasis { get; set; }

    public int FutureDaysAllowed { get; set; }
    public int PreviousDaysAllowed { get; set; }

    public decimal SystemStream { get; set; }

    public Guid DefaultContractorId { get; set; }
    public Guid DefaultProjectManagerId { get; set; }
    public Guid DefaultAccountManagerId { get; set; }

    public override void Configure(EntityTypeBuilder<ProviderOrganization> builder)
    {
        builder
            .HasOne(x => x.Organization)
            .WithOne(x => x.ProviderOrganization)
            .OnDelete(DeleteBehavior.Cascade);


        // Comment out HasMany calls to prevent duplicate relationship definitions
        // builder.HasMany(x => x.Projects)
        //     .WithOne(x => x.ProviderOrganization)
        //     .HasForeignKey(x => x.ProjectManagerOrganizationId)
        //     .OnDelete(DeleteBehavior.Restrict);


        // builder.HasMany(x => x.MarketingAgreements)
        //     .WithOne(x => x.ProviderOrganization)
        //     .HasForeignKey(x => x.ProviderOrganizationId)
        //     .OnDelete(DeleteBehavior.Cascade);

        // builder.HasMany(x => x.Contracts)
        //     .WithOne(x => x.ProviderOrganization)
        //     .HasForeignKey(x => x.ContractorOrganizationId)
        //     .OnDelete(DeleteBehavior.Restrict);

        // builder.HasMany(x => x.Leads)
        //     .WithOne(x => x.ProviderOrganization)
        //     .HasForeignKey(x => x.ProviderOrganizationId)
        //     .IsRequired();

        // builder.HasMany(x => x.Candidates)
        //     .WithOne(x => x.ProviderOrganization)
        //     .HasForeignKey(x => x.ProviderOrganizationId)
        //     .IsRequired();

        // builder.HasMany(x => x.CustomerAccounts)
        //     .WithOne(x => x.ProviderOrganization)
        //     .HasForeignKey(x => x.AccountManagerOrganizationId)
        //     .OnDelete(DeleteBehavior.Restrict);

        // builder.HasMany(x => x.Skills)
        //     .WithOne(x => x.Organization)
        //     .HasForeignKey(x => x.OrganizationId)
        //     .IsRequired()
        //     .OnDelete(DeleteBehavior.Cascade);


        builder.Property(x => x.AccountManagerStream).HasColumnType("Money");
        builder.Property(x => x.ProjectManagerStream).HasColumnType("Money");
        builder.Property(x => x.AgencyStream).HasColumnType("Money");
        builder.Property(x => x.ContractorStream).HasColumnType("Money");

        builder.Property(x => x.FutureDaysAllowed).HasDefaultValue(0);
        builder.Property(x => x.PreviousDaysAllowed).HasDefaultValue(14);

        builder.Property(x => x.AccountManagerStream).HasColumnType("Money");
        builder.Property(x => x.ProjectManagerStream).HasColumnType("Money");

        builder.Property(x => x.SystemStream).HasColumnType("Money");
        builder.Property(x => x.ContractorStream).HasColumnType("Money");

        // builder.HasMany(x => x.WorkOrders)
        //     .WithOne(x => x.ProviderOrganization)
        //     .HasForeignKey(x => x.AccountManagerOrganizationId)
        //     .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.DefaultContractor)
            .WithMany(x => x.DefaultOrganizations)
            .HasForeignKey(x => new
            {
                x.Id,
                x.DefaultContractorId
            }).IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.DefaultProjectManager)
            .WithMany(x => x.DefaultOrganizations)
            .HasForeignKey(x => new
            {
                x.Id,
                x.DefaultProjectManagerId
            }).IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.DefaultAccountManager)
            .WithMany(x => x.DefaultOrganizations)
            .HasForeignKey(x => new
            {
                x.Id,
                x.DefaultAccountManagerId
            }).IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        //builder.HasMany(x => x.Contractors)
        //    .WithOne(x => x.ProviderOrganization)
        //    .HasForeignKey(x => x.OrganizationId)
        //    .OnDelete(DeleteBehavior.Restrict);

        //builder.HasMany(x => x.ProjectManagers)
        //    .WithOne(x => x.ProviderOrganization)
        //    .HasForeignKey(x => x.OrganizationId)
        //    .OnDelete(DeleteBehavior.Restrict);

        //builder.HasMany(x => x.AccountManagers)
        //    .WithOne(x => x.ProviderOrganization)
        //    .HasForeignKey(x => x.OrganizationId)
        //    .OnDelete(DeleteBehavior.Restrict);
    }
}