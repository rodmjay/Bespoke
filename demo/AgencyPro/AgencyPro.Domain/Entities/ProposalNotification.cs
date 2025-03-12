namespace AgencyPro.Domain.Entities;

public class ProposalNotification : Notification<ProposalNotification>
{
    public Guid ProposalId { get; set; }
    public FixedPriceProposal Proposal { get; set; }

    public override void Configure(EntityTypeBuilder<ProposalNotification> builder)
    {
        builder.HasOne(x => x.Proposal)
            .WithMany(x => x.Notifications)
            .HasForeignKey(x => x.ProposalId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);
    }
}