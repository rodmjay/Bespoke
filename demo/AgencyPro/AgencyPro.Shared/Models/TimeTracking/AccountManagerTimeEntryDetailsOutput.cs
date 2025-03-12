namespace AgencyPro.Shared.Models.TimeTracking;

public class AccountManagerTimeEntryDetailsOutput : AccountManagerTimeEntryOutput
{
    public Dictionary<DateTimeOffset, TimeStatus> StatusTransitions { get; set; }
}