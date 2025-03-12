namespace AgencyPro.Domain.Entities;

public class PersonNotification : Notification<PersonNotification>
{
    public Guid PersonId { get; set; }
    public Person Person { get; set; }

    public override void Configure(EntityTypeBuilder<PersonNotification> builder)
    {
        builder.HasOne(x => x.Person)
            .WithMany(x => x.PersonNotifications)
            .HasForeignKey(x => x.PersonId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}