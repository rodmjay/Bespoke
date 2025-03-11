namespace AgencyPro.Shared.Models
{
    public class InvoiceResult : Result
    {
        public string InvoiceId { get; set; }
        public Guid? ProjectId { get; set; }
    }
}