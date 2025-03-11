namespace AgencyPro.Shared.Models
{
    public class AgencyOwnerCandidateDetailsOutput : AgencyOwnerCandidateOutput
    {
        public ICollection<CommentOutput> Comments { get; set; } = new List<CommentOutput>();
    }
}