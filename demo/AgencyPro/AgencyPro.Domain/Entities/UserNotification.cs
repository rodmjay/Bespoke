namespace AgencyPro.Domain.Entities
{
    public class UserNotification : Notification<UserNotification>
    {
        public User User { get; set; }
        public Guid PersonId { get; set; }
        public override void Configure(EntityTypeBuilder<UserNotification> builder)
        {
            builder.HasOne(x => x.User)
                .WithMany(x => x.Notifications)
                .HasForeignKey(x => x.PersonId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}