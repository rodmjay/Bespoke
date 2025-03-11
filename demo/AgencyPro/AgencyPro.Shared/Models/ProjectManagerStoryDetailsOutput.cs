namespace AgencyPro.Shared.Models
{
    public class ProjectManagerStoryDetailsOutput : ProjectManagerStoryOutput
    {
        public ICollection<CommentOutput> Comments { get; set; }
        public Dictionary<DateTimeOffset, StoryStatus> StatusTransitions { get; set; }
    }
}