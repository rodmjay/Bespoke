namespace AgencyPro.Shared.Models
{
    public class ContractorProjectInvoiceDetailsOutput : ContractorProjectInvoiceOutput
    {
        public ICollection<InvoiceLineOutput> Lines { get; set; }
    }
}