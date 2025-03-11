namespace AgencyPro.Shared.Models
{
    public class ContractorTimeEntryDetailsOutput : ContractorTimeEntryOutput
    {
        public Dictionary<DateTimeOffset, TimeStatus> StatusTransitions { get; set; }
    }
}