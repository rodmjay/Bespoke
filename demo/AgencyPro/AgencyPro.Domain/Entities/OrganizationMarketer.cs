namespace AgencyPro.Domain.Entities;

public class OrganizationMarketer : BaseEntity<OrganizationMarketer>
{
    public Guid OrganizationId { get; set; }
    public Organization Organization { get; set; }

    public ICollection<MarketingOrganization> OrganizationDefaults { get; set; }
    public ICollection<TimeEntry> TimeEntries { get; set; }

    public Guid MarketerId { get; set; }
    public Marketer Marketer { get; set; }

    public string ReferralCode { get; set; } = null!;

    public decimal MarketerStream { get; set; }

    public ICollection<Contract> Contracts { get; set; }
    public ICollection<Customer> Customers { get; set; }
    public ICollection<Lead> Leads { get; set; }
    public OrganizationMembership OrganizationMembership { get; set; }

    public bool IsSystemDefault { get; set; }
    public bool IsDeleted { get; set; }
    public virtual string ConcurrencyStamp { get; set; } = null!;


    public Guid CreatedById { get; set; }
    public Guid UpdatedById { get; set; }
    public decimal MarketerBonus { get; set; }

    public override void Configure(EntityTypeBuilder<OrganizationMarketer> builder)
    {
        builder
            .HasKey(x => new
            {
                x.OrganizationId,
                x.MarketerId
            });

        builder.Property(x => x.MarketerStream).HasColumnType("Money");
        builder.Property(x => x.MarketerBonus).HasColumnType("Money");

        builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();
        builder.HasQueryFilter(x => x.IsDeleted == false);


        builder
            .HasMany(x => x.Contracts)
            .WithOne(x => x.OrganizationMarketer)
            .HasForeignKey(x => new
            {
                x.MarketerOrganizationId,
                x.MarketerId
            });

        builder
            .HasMany(x => x.Leads)
            .WithOne(x => x.OrganizationMarketer)
            .HasForeignKey(x => new
            {
                x.MarketerOrganizationId,
                x.MarketerId
            });

        builder
            .HasOne(x => x.OrganizationMembership)
            .WithOne(x => x.Marketer)
            .HasForeignKey<OrganizationMarketer>(x => new
            {
                x.OrganizationId,
                x.MarketerId
            })
            .OnDelete(DeleteBehavior.Cascade);
    }
}