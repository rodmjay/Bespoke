using AgencyPro.Shared.Models.TimeTracking;

namespace AgencyPro.Shared.Models
{
    public class AccountManagerStoryDetailsOutput : AccountManagerStoryOutput
    {
        public ICollection<AccountManagerTimeEntryOutput> TimeEntries { get; set; }
        public ICollection<CommentOutput> Comments { get; set; }
        public Dictionary<DateTimeOffset, StoryStatus> StatusTransitions { get; set; }
    }
}