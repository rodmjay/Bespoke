namespace AgencyPro.Domain.Entities
{
    public class IndividualPayoutIntent : BaseEntity<IndividualPayoutIntent>, IIndividualPayoutIntent
    {
        public Guid Id { get; set; }

        public Guid PersonId { get; set; }
        public Person Person { get; set; }

        public Guid OrganizationId { get; set; }
        public Organization Organization { get; set; }

        public OrganizationMembership OrganizationMembership { get; set; }

        public string InvoiceId { get; set; } = null!;
        public StripeInvoice Invoice { get; set; }

        public string InvoiceItemId { get; set; } = null!;
        public StripeInvoiceItem InvoiceItem { get; set; }

        public decimal Amount { get; set; }
        public CommissionType Type { get; set; }

        public string Description { get; set; } = null!;
        
        public InvoiceTransfer InvoiceTransfer { get; set; }
        public string InvoiceTransferId { get; set; } = null!;
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }


        public override void Configure(EntityTypeBuilder<IndividualPayoutIntent> builder)
        {
            // id properties
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");

            builder.HasOne(x => x.Person)
                .WithMany(x => x.PayoutIntents)
                .HasForeignKey(x => x.PersonId)
                .IsRequired();

            builder.HasOne(x => x.Organization)
                .WithMany(x => x.IndividualPayoutIntents)
                .HasForeignKey(x => x.OrganizationId);

            builder.HasOne(x => x.OrganizationMembership)
                .WithMany(x => x.Payouts)
                .HasForeignKey(x => new
                {
                    x.OrganizationId,
                    x.PersonId
                });

            builder.HasOne(x => x.InvoiceItem)
                .WithMany(x => x.IndividualPayoutIntents)
                .HasForeignKey(x => x.InvoiceItemId)
                .IsRequired();

            builder.HasOne(x => x.InvoiceTransfer)
                .WithMany(x => x.IndividualPayoutIntents)
                .HasForeignKey(x => x.InvoiceTransferId)
                .IsRequired(false);

            
        }
    }
}
