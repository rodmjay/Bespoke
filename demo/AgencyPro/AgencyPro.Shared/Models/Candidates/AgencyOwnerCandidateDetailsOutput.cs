namespace AgencyPro.Shared.Models.Candidates
{
    public class AgencyOwnerCandidateDetailsOutput : AgencyOwnerCandidateOutput
    {
        public ICollection<CommentOutput> Comments { get; set; } = new List<CommentOutput>();
    }
}