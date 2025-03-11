namespace AgencyPro.Shared.Models
{
    public class InvoiceItemResult : Result
    {
        public string InvoiceItemId { get; set; }
        public int TimeEntriesUpdated { get; set; }
        public Guid ContractId { get; set; }
    }
}