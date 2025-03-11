namespace AgencyPro.Shared.Models
{
    public class CustomerTimeEntryDetailsOutput : CustomerTimeEntryOutput
    {
        public Dictionary<DateTimeOffset, TimeStatus> StatusTransitions { get; set; }
    }
}