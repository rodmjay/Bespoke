using AgencyPro.Shared.Models.TimeTracking;

namespace AgencyPro.Shared.Models.Contracts
{
    public class AccountManagerContractDetailsOutput : AccountManagerContractOutput
    {
        public ICollection<AccountManagerTimeEntryOutput> TimeEntries { get; set; }
        public ICollection<AccountManagerStoryOutput> Stories { get; set; }
        public ICollection<CommentOutput> Comments { get; set; }
        public Dictionary<DateTimeOffset, ContractStatus> StatusTransitions { get; set; }
    }
}