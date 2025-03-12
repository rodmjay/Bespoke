namespace AgencyPro.Domain.Entities;

public class WorkOrder : BaseEntity<WorkOrder>, IWorkOrder
{
    public ICollection<ProposalWorkOrder> Proposals { get; set; }
    public ICollection<WorkOrderNotification> WorkOrderNotifications { get; set; }
    public CustomerAccount CustomerAccount { get; set; }

    public AccountManager AccountManager { get; set; }
    public OrganizationAccountManager OrganizationAccountManager { get; set; }

    public ProviderOrganization ProviderOrganization { get; set; }
    public Organization BuyerOrganization { get; set; }

    public Customer Customer { get; set; }
    public bool IsDeleted { get; set; }

    public Guid AccountManagerId { get; set; }
    public Guid AccountManagerOrganizationId { get; set; }

    public Guid CustomerId { get; set; }
    public Guid CustomerOrganizationId { get; set; }

    public Guid Id { get; set; }

    public int BuyerNumber { get; set; }
    public int ProviderNumber { get; set; }

    public string Description { get; set; } = null!;

    public DateTimeOffset? ProviderResponseTime { get; set; }

    public OrderStatus Status { get; set; }

    public override void Configure(EntityTypeBuilder<WorkOrder> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasIndex("AccountManagerOrganizationId", "ProviderNumber")
            .HasDatabaseName("ProviderNumberIndex").IsUnique();

        builder.HasIndex("CustomerOrganizationId", "BuyerNumber")
            .HasDatabaseName("BuyerNumberIndex").IsUnique();

        builder.HasOne(x => x.AccountManager)
            .WithMany(x => x.WorkOrders)
            .HasForeignKey(x => x.AccountManagerId)
            .IsRequired(false);

        builder.HasOne(x => x.Customer)
            .WithMany(x => x.WorkOrders)
            .HasForeignKey(x => x.CustomerId)
            .IsRequired(false);

        builder.HasOne(x => x.CustomerAccount)
            .WithMany(x => x.WorkOrders)
            .HasForeignKey(x => new
            {
                x.CustomerOrganizationId,
                x.CustomerId,
                x.AccountManagerOrganizationId,
                x.AccountManagerId
            }).IsRequired(false);

        builder.HasOne(x => x.OrganizationAccountManager)
            .WithMany(x => x.WorkOrders)
            .HasForeignKey(x => new
            {
                x.AccountManagerOrganizationId,
                x.AccountManagerId
            });

        builder.HasOne(x => x.ProviderOrganization)
            .WithMany(x => x.WorkOrders)
            .HasForeignKey(x => x.AccountManagerOrganizationId);

        builder.HasQueryFilter(x => x.IsDeleted == false);
    }
}