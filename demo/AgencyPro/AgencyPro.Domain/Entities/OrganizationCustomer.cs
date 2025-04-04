﻿namespace AgencyPro.Domain.Entities;

public class OrganizationCustomer : BaseEntity<OrganizationCustomer>, IOrganizationCustomer
{
    public Customer Customer { get; set; }

    public Organization Organization { get; set; }
    public OrganizationMembership OrganizationMembership { get; set; }
    public ICollection<Contract> Contracts { get; set; }

    public ICollection<CustomerAccount> Accounts { get; set; }
    public ICollection<Project> Projects { get; set; }
    public ICollection<TimeEntry> TimeEntries { get; set; }

    public ICollection<ProjectInvoice> Invoices { get; set; }

    //public ICollection<OrganizationPayoutIntent> PayoutIntents { get; set; }
    public ICollection<ProposalAcceptance> ProposalsAccepted { get; set; }


    public bool IsDefault { get; set; }
    public bool IsDeleted { get; set; }
    public virtual string ConcurrencyStamp { get; set; }

    public Guid CreatedById { get; set; }
    public Guid UpdatedById { get; set; }
    public ICollection<ProjectRetainerIntent> RetainerIntents { get; set; }
    public Guid OrganizationId { get; set; }
    public Guid CustomerId { get; set; }

    public override void Configure(EntityTypeBuilder<OrganizationCustomer> builder)
    {
        builder
            .HasKey(x => new
            {
                x.OrganizationId,
                x.CustomerId
            });

        builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();
        builder.HasQueryFilter(x => x.IsDeleted == false);


        builder.HasOne(x => x.Customer)
            .WithMany(x => x.OrganizationCustomers)
            .HasForeignKey(x => x.CustomerId)
            .IsRequired(false);

        builder
            .HasMany(x => x.Accounts)
            .WithOne(x => x.OrganizationCustomer)
            .HasForeignKey(x => new
            {
                x.CustomerOrganizationId,
                x.CustomerId
            }).IsRequired(false);


        builder
            .HasOne(x => x.OrganizationMembership)
            .WithOne(x => x.Customer).HasForeignKey<OrganizationCustomer>(x => new
            {
                x.OrganizationId,
                x.CustomerId
            })
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);
    }
}