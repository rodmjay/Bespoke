namespace AgencyPro.Domain.Entities;

public class AccountManager : BaseEntity<AccountManager>, IAccountManager
{
    [ForeignKey("Id")] public Person Person { get; set; }

    public ICollection<OrganizationAccountManager> OrganizationAccountManagers { get; set; }
    public ICollection<WorkOrder> WorkOrders { get; set; }
    public ICollection<Project> Projects { get; set; }
    public ICollection<CustomerAccount> CustomerAccounts { get; set; }
    public ICollection<Lead> Leads { get; set; }
    public ICollection<Contract> Contracts { get; set; }
    public ICollection<TimeEntry> TimeEntries { get; set; }
    public ICollection<ProjectInvoice> Invoices { get; set; }

    public ICollection<ProjectRetainerIntent> RetainerIntents { get; set; }
    public Guid Id { get; set; }
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset Updated { get; set; }

    public override void Configure(EntityTypeBuilder<AccountManager> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");

        builder.HasOne(x => x.Person)
            .WithOne(x => x.AccountManager);

        builder.HasMany(x => x.OrganizationAccountManagers)
            .WithOne(x => x.AccountManager)
            .HasForeignKey(x => x.AccountManagerId)
            .IsRequired();
    }
}