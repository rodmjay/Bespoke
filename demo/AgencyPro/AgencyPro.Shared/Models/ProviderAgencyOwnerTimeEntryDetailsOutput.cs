namespace AgencyPro.Shared.Models
{
    public class ProviderAgencyOwnerTimeEntryDetailsOutput : ProviderAgencyOwnerTimeEntryOutput
    {
        public Dictionary<DateTimeOffset, TimeStatus> StatusTransitions { get; set; }
    }
}