﻿namespace AgencyPro.Domain.Entities;

public class StoryNotification : Notification<StoryNotification>
{
    public Guid StoryId { get; set; }
    public Story Story { get; set; }

    public override void Configure(EntityTypeBuilder<StoryNotification> builder)
    {
        builder.HasOne(x => x.Story)
            .WithMany(x => x.Notifications)
            .HasForeignKey(x => x.StoryId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}