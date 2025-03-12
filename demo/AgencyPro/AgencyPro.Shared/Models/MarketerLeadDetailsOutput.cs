namespace AgencyPro.Shared.Models;

public class MarketerLeadDetailsOutput : MarketerLeadOutput
{
    public ICollection<CommentOutput> Comments { get; set; }
    public Dictionary<DateTimeOffset, LeadStatus> StatusTransitions { get; set; }
}