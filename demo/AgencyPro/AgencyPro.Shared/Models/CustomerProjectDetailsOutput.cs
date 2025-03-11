namespace AgencyPro.Shared.Models
{
    public class CustomerProjectDetailsOutput : CustomerProjectOutput
    {
        public CustomerFixedPriceProposalDetailModel Proposal { get; set; }
        public Dictionary<DateTimeOffset, ProjectStatus> StatusTransitions { get; set; }
        public ICollection<CustomerContractOutput> Contracts { get; set; }
        public ICollection<CustomerStoryOutput> Stories { get; set; }
        public ICollection<CommentOutput> Comments { get; set; }
        public IDictionary<StoryStatus, int> StoryStatus => Stories.GroupBy(a => a.Status).ToDictionary(b => b.Key, b => b.Count());
        public IDictionary<ContractStatus, int> ContractStatus => Contracts.GroupBy(a => a.Status).ToDictionary(b => b.Key, b => b.Count());
        public IDictionary<string, int> InvoiceStatus { get; set; }
        public ICollection<CustomerTimeEntryOutput> PendingTimeEntries { get; set; }
    }
}