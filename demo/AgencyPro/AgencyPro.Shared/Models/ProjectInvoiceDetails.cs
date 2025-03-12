namespace AgencyPro.Shared.Models;

public class ProjectInvoiceDetails : ProjectInvoiceSummaryItem
{
    public ICollection<ContractInvoiceSummaryItem> Contracts { get; set; }
}