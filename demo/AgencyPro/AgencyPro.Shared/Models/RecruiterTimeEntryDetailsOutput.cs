namespace AgencyPro.Shared.Models
{
    public class RecruiterTimeEntryDetailsOutput : RecruiterTimeEntryOutput
    {
        public Dictionary<DateTimeOffset, TimeStatus> StatusTransitions { get; set; }
    }
}