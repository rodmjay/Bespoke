namespace AgencyPro.Shared.Models
{
    public class AgencyOwnerProviderContractDetailsOutput : AgencyOwnerProviderContractOutput
    {
        public ICollection<ProviderAgencyOwnerTimeEntryOutput> TimeEntries { get; set; }
        public ICollection<AgencyOwnerStoryOutput> Stories { get; set; }
        public ICollection<CommentOutput> Comments { get; set; }
        public Dictionary<DateTimeOffset, ContractStatus> StatusTransitions { get; set; }
    }
}