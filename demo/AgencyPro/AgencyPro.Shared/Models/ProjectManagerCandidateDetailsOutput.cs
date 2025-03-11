namespace AgencyPro.Shared.Models
{
    public class ProjectManagerCandidateDetailsOutput : ProjectManagerCandidateOutput
    {
        public ICollection<CommentOutput> Comments { get; set; } = new List<CommentOutput>();

    }
}