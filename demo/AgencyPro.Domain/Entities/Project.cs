using Bespoke.Core.Extensions;
using Newtonsoft.Json;

namespace AgencyPro.Domain.Entities
{
    public class Project : BaseEntity<Project>, IProject
    {
        private ICollection<Contract> _contracts;
        private ICollection<Comment> _comments;
        private ICollection<ProjectInvoice> _invoices;

        public OrganizationProjectManager OrganizationProjectManager { get; set; }
        public OrganizationAccountManager OrganizationAccountManager { get; set; }
        public OrganizationCustomer OrganizationCustomer { get; set; }
        public ICollection<ProjectNotification> Notifications { get; set; }

        public ICollection<Story> Stories { get; set; }

        public ICollection<TimeEntry> TimeEntries { get; set; }


        [JsonIgnore()]
        public virtual ICollection<Contract> Contracts
        {
            get => _contracts ??= new Collection<Contract>();
            set => _contracts = value;
        }

        public ICollection<Comment> Comments
        {
            get => _comments ??= new Collection<Comment>();
            set => _comments = value;
        }

        public ProviderOrganization ProviderOrganization { get; set; }
        public Organization BuyerOrganization { get; set; }

       
        public ICollection<ProjectInvoice> Invoices
        {
            get => _invoices ??= new Collection<ProjectInvoice>();
            set => _invoices = value;
        }
        
        public ICollection<ProjectBillingCategory> ProjectBillingCategories { get; set; }
       
        public FixedPriceProposal Proposal { get; set; }
        
        public CustomerAccount CustomerAccount { get; set; }

        public bool IsDeleted { get; set; }

        public Guid Id { get; set; }
        public ProjectStatus Status { get; set; }
        public string Name { get; set; } = null!;

        public string Abbreviation { get; set; } = null!;

        public Guid CustomerOrganizationId { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        public Guid ProjectManagerId { get; set; }
        public Guid ProjectManagerOrganizationId { get; set; }
        public ProjectManager ProjectManager { get; set; }

        public Guid AccountManagerId { get; set; }
        public Guid AccountManagerOrganizationId { get; set; }
        public AccountManager AccountManager { get; set; }

        public decimal WeightedContractorAverage =>
            Contracts.WeightedAverage(x => x.ContractorStream, x => x.MaxWeeklyHours);

        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }

        public decimal WeightedRecruiterAverage =>
            Contracts.WeightedAverage(x => x.RecruiterStream, x => x.MaxWeeklyHours);

        public decimal WeightedMarketerAverage =>
            Contracts.WeightedAverage(x => x.MarketerStream, x => x.MaxWeeklyHours);

        public decimal WeightedProjectManagerAverage =>
            Contracts.WeightedAverage(x => x.ProjectManagerStream, x => x.MaxWeeklyHours);

        public decimal WeightedAccountManagerAverage =>
            Contracts.WeightedAverage(x => x.AccountManagerStream, x => x.MaxWeeklyHours);

        public decimal WeightedAgencyAverage =>
            Contracts.WeightedAverage(x => x.AgencyStream, x => x.MaxWeeklyHours);

        public decimal WeightedRecruitingAgencyAverage =>
            Contracts.WeightedAverage(x => x.RecruitingAgencyStream, x => x.MaxWeeklyHours);

        public decimal WeightedMarketingAgencyAverage =>
            Contracts.WeightedAverage(x => x.MarketingAgencyStream, x => x.MaxWeeklyHours);

        public decimal WeightedSystemAverage =>
            Contracts.WeightedAverage(x => x.SystemStream, x => x.MaxWeeklyHours);

        public decimal AverageCustomerRate =>
            Contracts.WeightedAverage(x => x.CustomerRate, x => x.MaxWeeklyHours);


        public Guid CreatedById { get; set; }
        public Guid UpdatedById { get; set; }
        public bool AutoApproveTimeEntries { get; set; }


        public string ConcurrencyStamp { get; set; } = null!;
        public ProjectRetainerIntent ProjectRetainerIntent { get; set; }
        public override void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasIndex("AccountManagerOrganizationId", "Abbreviation")
                .HasDatabaseName("ProjectAbbreviationIndex").IsUnique();

            //builder.OwnsMany(x => x.StatusTransitions, a =>
            //{
            //    a.WithOwner().HasForeignKey(x => x.ProjectId);
            //    a.HasKey(x => x.Id);
            //    a.Property(x => x.Id).ValueGeneratedOnAdd();
            //    a.Ignore(x => x.ObjectState);
            //    a.Property(x => x.Created).HasDefaultValueSql("SYSDATETIMEOFFSET()");
            //});

            builder
                .HasOne(x => x.AccountManager)
                .WithMany(x => x.Projects)
                .HasForeignKey(x => x.AccountManagerId)
                .IsRequired(false);

            builder
                .HasOne(x => x.ProjectManager)
                .WithMany(x => x.Projects)
                .HasForeignKey(x => x.ProjectManagerId)
                .IsRequired(false);

            builder.HasOne(x => x.ProviderOrganization)
                .WithMany(x => x.Projects)
                .HasForeignKey(x => x.ProjectManagerOrganizationId)
                .IsRequired(false);

            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();


            builder.HasQueryFilter(x => x.IsDeleted == false);

            builder
                .HasOne(x => x.CustomerAccount)
                .WithMany(x => x.Projects)
                .HasForeignKey(x => new
                {
                    x.CustomerOrganizationId,
                    x.CustomerId,
                    x.AccountManagerOrganizationId,
                    x.AccountManagerId
                }).IsRequired(false);

            builder
                .HasMany(x => x.Invoices)
                .WithOne(x => x.Project)
                .HasForeignKey(x => x.ProjectId);

            builder.HasOne(x => x.OrganizationProjectManager)
                .WithMany(x => x.Projects)
                .HasForeignKey(x => new
                {
                    x.ProjectManagerOrganizationId,
                    x.ProjectManagerId
                });

            builder.HasOne(x => x.OrganizationAccountManager)
                .WithMany(x => x.Projects)
                .HasForeignKey(x => new
                {
                    x.AccountManagerOrganizationId,
                    x.AccountManagerId
                });

            builder.HasOne(x => x.OrganizationCustomer)
                .WithMany(x => x.Projects)
                .HasForeignKey(x => new
                {
                    x.CustomerOrganizationId,
                    x.CustomerId
                });

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Projects)
                .HasForeignKey(x => x.CustomerId);

            
        }
    }
}
