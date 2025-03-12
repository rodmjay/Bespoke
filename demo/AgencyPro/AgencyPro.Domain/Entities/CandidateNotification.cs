namespace AgencyPro.Domain.Entities;

public class CandidateNotification : Notification<CandidateNotification>
{
    public Guid CandidateId { get; set; }
    public Candidate Candidate { get; set; }

    public override void Configure(EntityTypeBuilder<CandidateNotification> builder)
    {
        builder.HasOne(x => x.Candidate)
            .WithMany(x => x.CandidateNotifications)
            .HasForeignKey(x => x.CandidateId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}