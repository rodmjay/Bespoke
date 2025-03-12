namespace AgencyPro.Domain.Entities;

public class Marketer : BaseEntity<Marketer>, IMarketer
{
    [ForeignKey("Id")] public Person Person { get; set; }

    public ICollection<Contract> Contracts { get; set; }
    public ICollection<Lead> Leads { get; set; }

    public ICollection<OrganizationMarketer> OrganizationMarketers { get; set; }
    public ICollection<TimeEntry> TimeEntries { get; set; }

    public Guid Id { get; set; }
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset Updated { get; set; }


    public override void Configure(EntityTypeBuilder<Marketer> builder)
    {
        builder
            .HasOne(x => x.Person)
            .WithOne(x => x.Marketer)
            .OnDelete(DeleteBehavior.Cascade);
    }
}