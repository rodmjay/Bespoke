namespace AgencyPro.Domain.Entities
{
    public class Customer : BaseEntity<Customer>, ICustomer
    {
        [ForeignKey("Id")] public Person Person { get; set; }

        public OrganizationMarketer OrganizationMarketer { get; set; }

        public ICollection<OrganizationCustomer> OrganizationCustomers { get; set; }
        public IndividualBuyerAccount BuyerAccount { get; set; }

        public ICollection<Organization> OwnedAgencies { get; set; }
        public ICollection<ProjectInvoice> Invoices { get; set; }
        public ICollection<ProposalAcceptance> ProposalsAccepted { get; set; }

        public ICollection<TimeEntry> ProviderTimeEntries { get; set; }
        public ICollection<TimeEntry> MarketingTimeEntries { get; set; }
        public ICollection<TimeEntry> RecruitingTimeEntries { get; set; }

        public ICollection<TimeEntry> BuyerTimeEntries { get; set; }

        public ICollection<Project> Projects { get; set; }
        public ICollection<CustomerAccount> CustomerAccounts { get; set; }
        public ICollection<CustomerCard> Cards { get; set; }
        public ICollection<WorkOrder> WorkOrders { get; set; }
        public ICollection<Contract> Contracts { get; set; }

        public Guid Id { get; set; }

        public Guid MarketerId { get; set; }
        public Guid MarketerOrganizationId { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }

        public ICollection<ProjectRetainerIntent> RetainerIntents { get; set; }

        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder
                .HasOne(x => x.Person)
                .WithOne(x => x.Customer);

            builder
                .HasOne(x => x.OrganizationMarketer)
                .WithMany(x => x.Customers)
                .HasForeignKey(x => new
                {
                    x.MarketerOrganizationId,
                    x.MarketerId
                });

            builder.HasMany(x => x.OrganizationCustomers)
                .WithOne(x => x.Customer)
                .HasForeignKey(x => x.CustomerId)
                .IsRequired();

            builder.HasOne(x => x.BuyerAccount)
                .WithOne(x => x.Customer)
                .HasForeignKey<IndividualBuyerAccount>(x => x.Id);

            
        }
    }
}