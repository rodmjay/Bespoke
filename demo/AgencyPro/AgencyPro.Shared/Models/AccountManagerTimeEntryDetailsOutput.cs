namespace AgencyPro.Shared.Models
{
    public class AccountManagerTimeEntryDetailsOutput : AccountManagerTimeEntryOutput
    {
        public Dictionary<DateTimeOffset, TimeStatus> StatusTransitions { get; set; }
    }
}