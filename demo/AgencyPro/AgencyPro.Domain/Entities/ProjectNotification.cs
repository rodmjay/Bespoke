namespace AgencyPro.Domain.Entities;

public class ProjectNotification : Notification<ProjectNotification>
{
    public Guid ProjectId { get; set; }
    public Project Project { get; set; }

    public override void Configure(EntityTypeBuilder<ProjectNotification> builder)
    {
        builder.HasOne(x => x.Project)
            .WithMany(x => x.Notifications)
            .HasForeignKey(x => x.ProjectId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}