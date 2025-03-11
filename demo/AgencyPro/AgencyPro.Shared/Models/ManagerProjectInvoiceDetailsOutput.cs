namespace AgencyPro.Shared.Models
{
    public class ManagerProjectInvoiceDetailsOutput : ManagerProjectInvoiceOutput
    {
        public ICollection<InvoiceLineOutput> Lines { get; set; }
    }
}