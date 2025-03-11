namespace AgencyPro.Domain.Entities
{
    public class CustomerAccount : BaseEntity<CustomerAccount>, ICustomerAccount
    {
        public bool IsDeleted { get; set; }


        public OrganizationCustomer OrganizationCustomer { get; set; }

        public ProviderOrganization ProviderOrganization { get; set; }
        public Organization BuyerOrganization { get; set; }
        public ServiceAgreement ServiceAgreement { get; set; }
        public OrganizationAccountManager OrganizationAccountManager { get; set; }

        public ICollection<Project> Projects { get; set; }
        public ICollection<WorkOrder> WorkOrders { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<ProjectInvoice> Invoices { get; set; } 
        public ICollection<Contract> Contracts { get; set; }

        public int BuyerNumber { get; set; }
        public int Number { get; set; }
        public Guid CustomerId { get; set; }
        public Guid CustomerOrganizationId { get; set; }
        public Customer Customer { get; set; }
        public AccountStatus AccountStatus { get; set; }

        public Guid AccountManagerId { get; set; }
        public Guid AccountManagerOrganizationId { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }

        public AccountManager AccountManager { get; set;  }
        public string ConcurrencyStamp { get; set; } = null!;

        public DateTimeOffset? AgencyOwnerDeactivationDate { get; set; }
        public DateTimeOffset? AccountManagerDeactivationDate { get; set; }
        public DateTimeOffset? CustomerDeactivationDate { get; set; }

        public Guid CreatedById { get; set; }
        public Guid UpdatedById { get; set; }

        public int PaymentTermId { get; set; }
        public PaymentTerm PaymentTerm { get; set; }


        public bool IsInternal
        {
            get => AccountManagerOrganizationId == CustomerOrganizationId;
            set
            {

            }
        }

        public bool IsCorporate
        {
            get =>
                (AccountManagerOrganizationId == CustomerOrganizationId) 
                && (AccountManagerId == CustomerId);
            set
            {

            }
        }

        public bool IsDeactivated
        {
            get =>
                AccountManagerDeactivationDate.HasValue 
                || AgencyOwnerDeactivationDate.HasValue 
                || CustomerDeactivationDate.HasValue;
            set { }
        }

        public decimal MarketerStream { get; set; }
        public decimal MarketingAgencyStream { get; set; }

        public string StripeCustomerId { get; set; } = null!;
        public bool AutoApproveTimeEntries { get; set; }
        public ICollection<ProjectRetainerIntent> RetainerIntents { get; set; }
        public override void Configure(EntityTypeBuilder<CustomerAccount> builder)
        {
            builder.HasQueryFilter(x => x.IsDeleted == false);

            builder.HasIndex("AccountManagerOrganizationId", "Number")
                .HasName("AccountNumberIndex").IsUnique();

            builder.HasIndex("CustomerOrganizationId", "BuyerNumber")
                .HasName("BuyerNumberIndex").IsUnique();

            builder.Property(x => x.IsDeactivated).HasComputedColumnSql(
                @"case when (coalesce([AgencyOwnerDeactivationDate],[AccountManagerDeactivationDate],[CustomerDeactivationDate]) is null) then cast(0 as bit) else cast(1 as bit) end");

            builder.Property(x => x.IsInternal)
                .HasComputedColumnSql(@"case when [AccountManagerOrganizationId]=[CustomerOrganizationId] then cast(1 as bit) else cast(0 as bit) end");

            builder.Property(x => x.IsCorporate)
                .HasComputedColumnSql(@"case when [AccountManagerOrganizationId]=[CustomerOrganizationId] AND [AccountManagerId]=[CustomerId] then cast(1 as bit) else cast(0 as bit) end");

            builder
                .HasKey(x => new
                {
                    x.CustomerOrganizationId,
                    x.CustomerId,
                    x.AccountManagerOrganizationId,
                    x.AccountManagerId
                });
            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            builder.HasOne(x => x.AccountManager)
                .WithMany(x => x.CustomerAccounts)
                .HasForeignKey(x => x.AccountManagerId)
                .IsRequired(false);

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.CustomerAccounts)
                .HasForeignKey(x => x.CustomerId)
                .IsRequired(false);

            builder.HasMany(x => x.Contracts)
                .WithOne(x => x.CustomerAccount)
                .HasForeignKey(x => new
                {
                    x.BuyerOrganizationId,
                    x.CustomerId,
                    x.AccountManagerOrganizationId,
                    x.AccountManagerId
                }).IsRequired(false);

            builder
                .HasOne(x => x.OrganizationAccountManager)
                .WithMany(x => x.Accounts)
                .HasForeignKey(x => new
                {
                    x.AccountManagerOrganizationId,
                    x.AccountManagerId
                });

            builder
                .HasOne(x => x.OrganizationCustomer)
                .WithMany(x => x.Accounts)
                .HasForeignKey(x => new
                {
                    x.CustomerOrganizationId,
                    x.CustomerId
                });

            builder.Property(x => x.PaymentTermId).HasDefaultValue(1);

            builder.HasOne(x => x.PaymentTerm)
                .WithMany(x => x.CustomerAccounts)
                .HasForeignKey(x => x.PaymentTermId);

            // Comment out HasMany calls to prevent duplicate relationship definitions
            // builder.HasMany(x => x.Projects).WithOne(x => x.CustomerAccount).HasForeignKey(x => new
            // {
            //     x.CustomerOrganizationId,
            //     x.CustomerId,
            //     x.AccountManagerOrganizationId,
            //     x.AccountManagerId
            // }).IsRequired();

            // builder.HasMany(x => x.WorkOrders).WithOne(x => x.CustomerAccount).HasForeignKey(x => new
            // {
            //     x.CustomerOrganizationId,
            //     x.CustomerId,
            //     x.AccountManagerOrganizationId,
            //     x.AccountManagerId
            // }).IsRequired();

            // builder.HasMany(x => x.Comments).WithOne(x => x.CustomerAccount).HasForeignKey(x => new
            // {
            //     x.CustomerOrganizationId,
            //     x.CustomerId,
            //     x.AccountManagerOrganizationId,
            //     x.AccountManagerId
            // }).IsRequired(false)
            //     .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.ProviderOrganization)
                .WithMany(x => x.CustomerAccounts)
                .HasForeignKey(x => x.AccountManagerOrganizationId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.BuyerOrganization)
                .WithMany(x => x.BuyerCustomerAccounts)
                .HasForeignKey(x => x.CustomerOrganizationId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.ServiceAgreement)
                .WithOne(x => x.CustomerAccount)
                .HasForeignKey<ServiceAgreement>(x => new
                {
                    x.CustomerOrganizationId,
                    x.CustomerId,
                    x.AccountManagerOrganizationId,
                    x.AccountManagerId
                });


            builder.Property(x => x.MarketerStream).HasColumnType("Money");
            builder.Property(x => x.MarketingAgencyStream).HasColumnType("Money");

            
        }
    }
}
