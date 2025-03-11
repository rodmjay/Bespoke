namespace AgencyPro.Shared.Models
{
    public class AccountManagerLeadDetailsOutput : AccountManagerLeadOutput
    {
        public ICollection<CommentOutput> Comments { get; set; }
        public Dictionary<DateTimeOffset, LeadStatus> StatusTransitions { get; set; }
    }
}