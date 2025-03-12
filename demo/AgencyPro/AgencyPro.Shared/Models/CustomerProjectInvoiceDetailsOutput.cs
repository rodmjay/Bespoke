namespace AgencyPro.Shared.Models;

public class CustomerProjectInvoiceDetailsOutput : CustomerProjectInvoiceOutput
{
    public ICollection<InvoiceLineOutput> Lines { get; set; }
}