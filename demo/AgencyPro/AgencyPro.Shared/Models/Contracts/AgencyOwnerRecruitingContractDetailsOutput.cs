namespace AgencyPro.Shared.Models.Contracts
{
    public class AgencyOwnerRecruitingContractDetailsOutput : AgencyOwnerRecruitingContractOutput
    {
        public ICollection<CommentOutput> Comments { get; set; } = new List<CommentOutput>();
    }
}