namespace AgencyPro.Shared.Models.Leads
{
    public class AgencyOwnerLeadDetailsOutput : AgencyOwnerLeadOutput
    {
        public ICollection<CommentOutput> Comments { get; set; }
        public Dictionary<DateTimeOffset, LeadStatus> StatusTransitions { get; set; }
    }
}