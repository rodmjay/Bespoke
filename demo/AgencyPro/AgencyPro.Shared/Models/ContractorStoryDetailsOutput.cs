namespace AgencyPro.Shared.Models
{
    public class ContractorStoryDetailsOutput : ContractorStoryOutput
    {
        public ICollection<ContractorTimeEntryOutput> TimeEntries { get; set; }
        public ICollection<CommentOutput> Comments { get; set; }
        public Dictionary<DateTimeOffset, StoryStatus> StatusTransitions { get; set; }
    }
}