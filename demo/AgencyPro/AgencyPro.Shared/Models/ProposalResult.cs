namespace AgencyPro.Shared.Models
{

    public class ProposalResult : Result
    {
        public Guid ProposalId { get; set; }
        public string ProposalPdfUrl { get; set; }
    }
}