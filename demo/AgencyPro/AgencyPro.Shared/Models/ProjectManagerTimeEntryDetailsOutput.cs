namespace AgencyPro.Shared.Models;

public class ProjectManagerTimeEntryDetailsOutput : ProjectManagerTimeEntryOutput
{
    public Dictionary<DateTimeOffset, TimeStatus> StatusTransitions { get; set; }
}