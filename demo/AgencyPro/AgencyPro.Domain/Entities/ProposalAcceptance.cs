﻿namespace AgencyPro.Domain.Entities;

public class ProposalAcceptance : BaseEntity<ProposalAcceptance>
{
    public Guid Id { get; set; }

    [ForeignKey("Id")] public FixedPriceProposal Proposal { get; set; }

    public DateTimeOffset AcceptedCompletionDate { get; set; }

    public decimal TotalCost { get; set; }

    public int NetTerms { get; set; }

    public decimal? RetainerAmount { get; set; }

    public string ProposalBlob { get; set; } = null!;
    public decimal CustomerRate { get; set; }
    public string AgreementText { get; set; } = null!;
    public ProposalType ProposalType { get; set; }
    public decimal TotalDays { get; set; }
    public decimal Velocity { get; set; }

    public Guid AcceptedBy { get; set; }
    public Guid CustomerId { get; set; }

    public Customer Customer { get; set; }

    public Guid CustomerOrganizationId { get; set; }
    public OrganizationCustomer OrganizationCustomer { get; set; }

    public override void Configure(EntityTypeBuilder<ProposalAcceptance> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .HasOne(x => x.Proposal)
            .WithOne(x => x.ProposalAcceptance);


        builder.Property(x => x.AgreementText);
        builder.Property(x => x.CustomerRate).HasColumnType("Money");
        builder.Property(x => x.TotalDays);
        builder.Property(x => x.Velocity);
        builder.Property(x => x.ProposalType);


        builder.HasOne(x => x.Customer)
            .WithMany(x => x.ProposalsAccepted)
            .HasForeignKey(x => x.CustomerId)
            .IsRequired();

        builder.HasOne(x => x.OrganizationCustomer)
            .WithMany(x => x.ProposalsAccepted)
            .HasForeignKey(x => new
            {
                x.CustomerOrganizationId,
                x.CustomerId
            })
            .IsRequired();
    }
}