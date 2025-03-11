namespace AgencyPro.Shared.Models
{
    public class ContractorContractDetailsOutput : ContractorContractOutput
    {
        public ICollection<ContractorTimeEntryOutput> TimeEntries { get; set; }
        public ICollection<ContractorStoryOutput> Stories { get; set; }
        public ICollection<CommentOutput> Comments { get; set; }
        public Dictionary<DateTimeOffset, ContractStatus> StatusTransitions { get; set; }
    }
}