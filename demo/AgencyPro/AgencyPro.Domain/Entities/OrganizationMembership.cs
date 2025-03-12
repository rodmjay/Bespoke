namespace AgencyPro.Domain.Entities;

public class OrganizationMembership : BaseEntity<OrganizationMembership>, IOrganizationMembership
{
    public Organization Organization { get; set; } = null!;

    public Person Person { get; set; } = null!;

    public ICollection<IndividualPayoutIntent> Payouts { get; set; } = new List<IndividualPayoutIntent>();
    public ICollection<IndividualBonusIntent> Bonuses { get; set; } = new List<IndividualBonusIntent>();

    public OrganizationAccountManager AccountManager { get; set; } = null!;
    public OrganizationProjectManager ProjectManager { get; set; } = null!;
    public OrganizationCustomer Customer { get; set; } = null!;
    public OrganizationContractor Contractor { get; set; } = null!;
    public OrganizationRecruiter Recruiter { get; set; } = null!;
    public OrganizationMarketer Marketer { get; set; } = null!;

    public string ConcurrencyStamp { get; set; } = null!;

    public Guid CreatedById { get; set; }
    public Guid UpdatedById { get; set; }

    public string AffiliateCode { get; set; } = null!;
    public Guid OrganizationId { get; set; }
    public Guid PersonId { get; set; }

    public bool IsDeleted { get; set; }

    public PersonStatus Status { get; set; }

    public bool IsHidden { get; set; }

    public long PersonFlags { get; set; }
    public long AgencyFlags { get; set; }

    public bool IsOrganizationOwner { get; set; }
    public bool IsDefault { get; set; }
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset Updated { get; set; }

    public override void Configure(EntityTypeBuilder<OrganizationMembership> builder)
    {
        builder
            .HasKey(x => new { x.OrganizationId, x.PersonId });

        builder.HasQueryFilter(x => x.IsDeleted == false);
        builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

        builder.HasMany(x => x.Payouts)
            .WithOne(x => x.OrganizationMembership)
            .HasForeignKey(x => new
            {
                x.OrganizationId,
                x.PersonId
            }).IsRequired(false);


        builder
            .HasOne(x => x.Person)
            .WithMany(x => x.OrganizationPeople)
            .HasForeignKey(x => x.PersonId)
            .IsRequired(false);

        builder
            .HasOne(x => x.Organization)
            .WithMany(x => x.OrganizationPeople)
            .HasForeignKey(x => x.OrganizationId)
            .IsRequired(false);
    }
}