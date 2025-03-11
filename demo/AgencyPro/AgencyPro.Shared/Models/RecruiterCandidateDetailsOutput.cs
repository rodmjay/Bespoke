namespace AgencyPro.Shared.Models
{
    public class RecruiterCandidateDetailsOutput : RecruiterCandidateOutput
    {
        public ICollection<CommentOutput> Comments { get; set; } = new List<CommentOutput>();

    }
}