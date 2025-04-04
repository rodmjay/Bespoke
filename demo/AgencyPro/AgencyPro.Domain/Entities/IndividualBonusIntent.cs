﻿namespace AgencyPro.Domain.Entities;

public class IndividualBonusIntent : BaseEntity<IndividualBonusIntent>, IIndividualBonusIntent
{
    public Guid OrganizationId { get; set; }

    public Person Person { get; set; }
    public OrganizationMembership OrganizationMembership { get; set; }

    public BonusTransfer BonusTransfer { get; set; }


    public Guid? LeadId { get; set; }
    public Lead Lead { get; set; }

    public Guid? CandidateId { get; set; }
    public Candidate Candidate { get; set; }
    public Guid Id { get; set; }

    public Guid PersonId { get; set; }

    public BonusType BonusType { get; set; }
    public string TransferId { get; set; } = null!;

    public decimal Amount { get; set; }
    public string Description { get; set; } = null!;
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset Updated { get; set; }

    public override void Configure(EntityTypeBuilder<IndividualBonusIntent> builder)
    {
        // id properties
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");

        builder.HasOne(x => x.Person)
            .WithMany(x => x.BonusIntents)
            .HasForeignKey(x => x.PersonId)
            .IsRequired();

        builder.HasOne(x => x.OrganizationMembership)
            .WithMany(x => x.Bonuses)
            .HasForeignKey(x => new
            {
                x.OrganizationId,
                x.PersonId
            });

        builder.HasOne(x => x.BonusTransfer)
            .WithMany(x => x.IndividualBonusIntents)
            .HasForeignKey(x => x.TransferId)
            .IsRequired(false);
    }
}