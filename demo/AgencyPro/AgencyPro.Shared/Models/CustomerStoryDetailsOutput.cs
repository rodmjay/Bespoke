namespace AgencyPro.Shared.Models
{
    public class CustomerStoryDetailsOutput : CustomerStoryOutput
    {
        public ICollection<CommentOutput> Comments { get; set; }
        public Dictionary<DateTimeOffset, StoryStatus> StatusTransitions { get; set; }
    }
}