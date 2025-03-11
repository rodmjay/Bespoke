namespace AgencyPro.Shared.Models
{
    public class AgencyOwnerMarketingContractDetailsOutput : AgencyOwnerMarketingContractOutput
    {
        public ICollection<CommentOutput> Comments { get; set; } = new List<CommentOutput>();
    }
}