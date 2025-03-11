namespace AgencyPro.Shared.Models
{
    public class AccountManagerContractDetailsOutput : AccountManagerContractOutput
    {
        public ICollection<AccountManagerTimeEntryOutput> TimeEntries { get; set; }
        public ICollection<AccountManagerStoryOutput> Stories { get; set; }
        public ICollection<CommentOutput> Comments { get; set; }
        public Dictionary<DateTimeOffset, ContractStatus> StatusTransitions { get; set; }
    }
}