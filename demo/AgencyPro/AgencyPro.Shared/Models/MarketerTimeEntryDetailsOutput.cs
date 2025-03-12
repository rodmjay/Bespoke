namespace AgencyPro.Shared.Models;

public class MarketerTimeEntryDetailsOutput : MarketerTimeEntryOutput
{
    public Dictionary<DateTimeOffset, TimeStatus> StatusTransitions { get; set; }
}