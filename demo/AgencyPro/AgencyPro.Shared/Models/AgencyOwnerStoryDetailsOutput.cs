namespace AgencyPro.Shared.Models
{
    public class AgencyOwnerStoryDetailsOutput : AgencyOwnerStoryOutput
    {
        public ICollection<ProviderAgencyOwnerTimeEntryOutput> TimeEntries { get; set; }
        public ICollection<CommentOutput> Comments { get; set; }
        public Dictionary<DateTimeOffset, StoryStatus> StatusTransitions { get; set; }
    }
}