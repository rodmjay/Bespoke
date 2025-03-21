﻿namespace AgencyPro.Domain.Entities;

public class Contract : BaseEntity<Contract>, IContract
{
    private ICollection<Comment> _comments;


    private ICollection<ContractNotification> _notifications;

    public OrganizationContractor OrganizationContractor { get; set; }
    public OrganizationMarketer OrganizationMarketer { get; set; }
    public OrganizationRecruiter OrganizationRecruiter { get; set; }
    public Project Project { get; set; }

    public ProviderOrganization ProviderOrganization { get; set; }
    public MarketingOrganization MarketerOrganization { get; set; }
    public RecruitingOrganization RecruiterOrganization { get; set; }

    public ICollection<Comment> Comments
    {
        get => _comments ??= new Collection<Comment>();
        set => _comments = value;
    }

    public virtual ICollection<ContractNotification> Notifications
    {
        get => _notifications ??= new Collection<ContractNotification>();
        set => _notifications = value;
    }

    public ICollection<TimeEntry> TimeEntries { get; set; }
    public Contractor Contractor { get; set; }
    public Guid AccountManagerId { get; set; }
    public Guid AccountManagerOrganizationId { get; set; }
    public AccountManager AccountManager { get; set; }
    public ProjectManager ProjectManager { get; set; }
    public Guid ProjectManagerId { get; set; }
    public Guid ProjectManagerOrganizationId { get; set; }
    public OrganizationProjectManager OrganizationProjectManager { get; set; }
    public OrganizationAccountManager OrganizationAccountManager { get; set; }
    public Marketer Marketer { get; set; }
    public Recruiter Recruiter { get; set; }

    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; }
    public Guid BuyerOrganizationId { get; set; }
    public Organization BuyerOrganization { get; set; }
    public OrganizationCustomer OrganizationCustomer { get; set; }

    public CustomerAccount CustomerAccount { get; set; }

    public DateTimeOffset? ContractorPauseDate { get; set; }
    public DateTimeOffset? CustomerPauseDate { get; set; }
    public DateTimeOffset? AgencyOwnerPauseDate { get; set; }
    public DateTimeOffset? AccountManagerPauseDate { get; set; }

    public ContractStatus Status { get; set; }

    public bool IsPaused
    {
        get => ContractorPauseDate.HasValue ||
               CustomerPauseDate.HasValue ||
               AgencyOwnerPauseDate.HasValue ||
               AccountManagerPauseDate.HasValue;
        private set { }
    }

    public DateTimeOffset? ContractorEndDate { get; set; }
    public DateTimeOffset? CustomerEndDate { get; set; }
    public DateTimeOffset? AgencyOwnerEndDate { get; set; }
    public DateTimeOffset? AccountManagerEndDate { get; set; }

    public bool IsEnded
    {
        get => ContractorEndDate.HasValue ||
               CustomerEndDate.HasValue ||
               AgencyOwnerEndDate.HasValue ||
               AccountManagerEndDate.HasValue;
        private set { }
    }

    public decimal TotalHoursLogged { get; set; }

    public ICollection<StripeInvoiceItem> InvoiceItems { get; set; }

    public Guid Id { get; set; }

    public int ProviderNumber { get; set; }
    public int BuyerNumber { get; set; }
    public int MarketingNumber { get; set; }
    public int RecruitingNumber { get; set; }

    public Guid ContractorId { get; set; }
    public Guid ContractorOrganizationId { get; set; }

    public Guid MarketerId { get; set; }
    public Guid MarketerOrganizationId { get; set; }

    public Guid RecruiterId { get; set; }
    public Guid RecruiterOrganizationId { get; set; }


    public int MaxWeeklyHours { get; set; }

    public decimal ContractorStream { get; set; }
    public decimal MarketerStream { get; set; }
    public decimal AccountManagerStream { get; set; }
    public decimal ProjectManagerStream { get; set; }
    public decimal RecruiterStream { get; set; }
    public decimal SystemStream { get; set; }
    public decimal AgencyStream { get; set; }
    public decimal RecruitingAgencyStream { get; set; }
    public decimal MarketingAgencyStream { get; set; }

    public decimal CustomerRate
    {
        get => ContractorStream + MarketerStream + AccountManagerStream + ProjectManagerStream +
               RecruiterStream + SystemStream + AgencyStream + RecruitingAgencyStream + MarketingAgencyStream;
        private set { }
    }

    public decimal MaxCustomerWeekly
    {
        get => CustomerRate * MaxWeeklyHours;
        private set { }
    }

    public decimal MaxContractorWeekly
    {
        get => ContractorStream * MaxWeeklyHours;
        private set { }
    }

    public decimal MaxRecruiterWeekly
    {
        get => RecruiterStream * MaxWeeklyHours;
        private set { }
    }

    public decimal MaxMarketerWeekly
    {
        get => MarketerStream * MaxWeeklyHours;
        private set { }
    }

    public decimal MaxProjectManagerWeekly
    {
        get => ProjectManagerStream * MaxWeeklyHours;
        private set { }
    }

    public decimal MaxAccountManagerWeekly
    {
        get => AccountManagerStream * MaxWeeklyHours;
        private set { }
    }

    public decimal MaxAgencyWeekly
    {
        get => AgencyStream * MaxWeeklyHours;
        private set { }
    }

    public decimal MaxSystemWeekly
    {
        get => SystemStream * MaxWeeklyHours;
        private set { }
    }

    public Guid ProjectId { get; set; }
    public Guid CreatedById { get; set; }
    public Guid UpdatedById { get; set; }
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset Updated { get; set; }

    public bool IsDeleted { get; set; }

    public decimal MaxRecruitingAgencyWeekly
    {
        get => RecruitingAgencyStream * MaxWeeklyHours;

        private set { }
    }

    public decimal MaxMarketingAgencyWeekly
    {
        get => MarketingAgencyStream * MaxWeeklyHours;

        private set { }
    }

    public override void Configure(EntityTypeBuilder<Contract> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasIndex(nameof(ContractorOrganizationId), nameof(ProviderNumber))
            .HasDatabaseName($@"Contract{nameof(ProviderNumber)}Index").IsUnique();
        builder.HasIndex(nameof(MarketerOrganizationId), nameof(MarketingNumber))
            .HasDatabaseName($@"Contract{nameof(MarketingNumber)}Index").IsUnique();
        builder.HasIndex(nameof(RecruiterOrganizationId), nameof(RecruitingNumber))
            .HasDatabaseName($@"Contract{nameof(RecruitingNumber)}Index").IsUnique();

        builder.Property(x => x.Id)
            .HasDefaultValueSql("NEWID()");
        builder.HasQueryFilter(z => !z.IsDeleted);
        builder.Property(x => x.ContractorStream).HasColumnType("Money");
        builder.Property(x => x.ProjectManagerStream).HasColumnType("Money");
        builder.Property(x => x.AccountManagerStream).HasColumnType("Money");
        builder.Property(x => x.RecruiterStream).HasColumnType("Money");
        builder.Property(x => x.MarketerStream).HasColumnType("Money");
        builder.Property(x => x.AgencyStream).HasColumnType("Money");
        builder.Property(x => x.RecruitingAgencyStream).HasColumnType("Money");
        builder.Property(x => x.MarketingAgencyStream).HasColumnType("Money");
        builder.Property(x => x.SystemStream).HasColumnType("Money");

        var customerRateComputation =
            @"[ContractorStream]+[RecruiterStream]+[ProjectManagerStream]+[AccountManagerStream]+[MarketerStream]+[AgencyStream]+[MarketingAgencyStream]+[RecruitingAgencyStream]+[SystemStream]";
        builder.Property(x => x.CustomerRate).HasComputedColumnSql(customerRateComputation).HasColumnType("Money");

        builder.Property(x => x.MaxCustomerWeekly).HasComputedColumnSql(
            $@"({customerRateComputation})*[MaxWeeklyHours]");

        builder.Property(x => x.MaxContractorWeekly).HasComputedColumnSql(
            @"([ContractorStream]*[MaxWeeklyHours])");

        builder.Property(x => x.MaxRecruiterWeekly).HasComputedColumnSql(
            @"([RecruiterStream]*[MaxWeeklyHours])");

        builder.Property(x => x.MaxMarketerWeekly).HasComputedColumnSql(
            @"([MarketerStream]*[MaxWeeklyHours])");

        builder.Property(x => x.MaxProjectManagerWeekly).HasComputedColumnSql(
            @"([ProjectManagerStream]*[MaxWeeklyHours])");

        builder.Property(x => x.MaxAccountManagerWeekly).HasComputedColumnSql(
            @"([AccountManagerStream]*[MaxWeeklyHours])");

        builder.Property(x => x.MaxAgencyWeekly).HasComputedColumnSql(
            @"([AgencyStream]*[MaxWeeklyHours])");

        builder.Property(x => x.MaxSystemWeekly).HasComputedColumnSql(
            @"([SystemStream]*[MaxWeeklyHours])");

        builder.Property(x => x.MaxMarketingAgencyWeekly).HasComputedColumnSql(
            @"([MarketingAgencyStream]*[MaxWeeklyHours])");

        builder.Property(x => x.MaxRecruitingAgencyWeekly).HasComputedColumnSql(
            @"([RecruitingAgencyStream]*[MaxWeeklyHours])");

        builder.Property(x => x.IsPaused).HasComputedColumnSql(
            @"case when (coalesce([AgencyOwnerPauseDate],[AccountManagerPauseDate],[ContractorPauseDate],[CustomerPauseDate]) is null) then cast(0 as bit) else cast(1 as bit) end");

        builder.Property(x => x.IsPaused).HasComputedColumnSql(
            @"case when (coalesce([AgencyOwnerPauseDate],[AccountManagerPauseDate],[ContractorPauseDate],[CustomerPauseDate]) is null) then cast(0 as bit) else cast(1 as bit) end");

        builder.Property(x => x.IsEnded).HasComputedColumnSql(
            @"case when (coalesce([AgencyOwnerEndDate],[AccountManagerEndDate],[ContractorEndDate],[CustomerEndDate]) is null) then cast(0 as bit) else cast(1 as bit) end");

        builder.HasOne(x => x.Contractor)
            .WithMany(x => x.Contracts)
            .HasForeignKey(x => x.ContractorId);

        builder.HasOne(x => x.Recruiter)
            .WithMany(x => x.Contracts)
            .HasForeignKey(x => x.RecruiterId);

        builder.HasOne(x => x.Marketer)
            .WithMany(x => x.Contracts)
            .HasForeignKey(x => x.MarketerId);

        builder.HasOne(x => x.ProjectManager)
            .WithMany(x => x.Contracts)
            .HasForeignKey(x => x.ProjectManagerId)
            .IsRequired(false);

        builder.HasOne(x => x.AccountManager)
            .WithMany(x => x.Contracts)
            .HasForeignKey(x => x.AccountManagerId)
            .IsRequired(false);


        builder
            .HasOne(x => x.Project)
            .WithMany(x => x.Contracts)
            .HasForeignKey(x => x.ProjectId)
            .IsRequired(false);

        builder
            .HasOne(x => x.OrganizationContractor)
            .WithMany(x => x.Contracts)
            .HasForeignKey(x => new
            {
                x.ContractorOrganizationId,
                x.ContractorId
            })
            .IsRequired(false);

        builder.HasOne(x => x.OrganizationRecruiter)
            .WithMany(x => x.Contracts)
            .HasForeignKey(x => new
            {
                x.RecruiterOrganizationId,
                x.RecruiterId
            })
            .IsRequired(false);

        builder.HasMany(x => x.InvoiceItems)
            .WithOne(x => x.Contract)
            .HasForeignKey(x => x.ContractId)
            .IsRequired(false);

        builder.HasOne(x => x.OrganizationAccountManager)
            .WithMany(x => x.Contracts)
            .HasForeignKey(x => new
            {
                x.AccountManagerOrganizationId,
                x.AccountManagerId
            });

        builder.HasOne(x => x.OrganizationProjectManager)
            .WithMany(x => x.Contracts)
            .HasForeignKey(x => new
            {
                x.ProjectManagerOrganizationId,
                x.ProjectManagerId
            });

        builder.HasOne(x => x.Customer)
            .WithMany(x => x.Contracts)
            .HasForeignKey(x => x.CustomerId)
            .IsRequired(false);

        builder.HasOne(x => x.BuyerOrganization)
            .WithMany(x => x.BuyerContracts)
            .HasForeignKey(x => x.BuyerOrganizationId)
            .IsRequired(false);

        builder.HasOne(x => x.OrganizationCustomer)
            .WithMany(x => x.Contracts)
            .HasForeignKey(x => new
            {
                x.BuyerOrganizationId,
                x.CustomerId
            })
            .IsRequired(false);
    }
}