namespace AgencyPro.Shared.Models
{
    public class AgencyOwnerRecruitingContractDetailsOutput : AgencyOwnerRecruitingContractOutput
    {
        public ICollection<CommentOutput> Comments { get; set; } = new List<CommentOutput>();
    }
}