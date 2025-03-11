namespace AgencyPro.Domain.Entities
{
    public class OrganizationPayoutIntent : BaseEntity<OrganizationPayoutIntent>, IOrganizationPayoutIntent
    {
        public Guid Id { get; set; }

        public Organization Organization { get; set; }
        public Guid OrganizationId { get; set; }
        public Guid AgencyOwnerId { get; set; }

        //public OrganizationCustomer AgencyOwner { get; set; }

        public string InvoiceItemId { get; set; } = null!;
        public StripeInvoiceItem InvoiceItem { get; set; }

        public decimal Amount { get; set; }
        public CommissionType Type { get; set; }

        public string Description { get; set; } = null!;


        public string InvoiceId { get; set; } = null!;
        public StripeInvoice Invoice { get; set; }


        public InvoiceTransfer InvoiceTransfer { get; set; }
        public string InvoiceTransferId { get; set; } = null!;
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }


        public override void Configure(EntityTypeBuilder<OrganizationPayoutIntent> builder)
        {
            // id properties
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");

            builder.HasOne(x => x.Organization)
                .WithMany(x => x.PayoutIntents)
                .HasForeignKey(x => x.OrganizationId)
                .IsRequired();

            builder.HasOne(x => x.InvoiceItem)
                .WithMany(x => x.OrganizationPayoutIntents)
                .HasForeignKey(x => x.InvoiceItemId)
                .IsRequired();

            builder.HasOne(x => x.InvoiceTransfer)
                .WithMany(x => x.OrganizationPayoutIntents)
                .HasForeignKey(x => x.InvoiceTransferId)
                .IsRequired(false);

            
        }
    }
}
