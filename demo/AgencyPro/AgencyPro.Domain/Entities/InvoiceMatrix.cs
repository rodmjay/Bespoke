namespace AgencyPro.Domain.Entities;

public class InvoiceMatrix : IInvoiceMatrix
{
    public Guid AccountManagerId { get; set; }
    public Guid AccountManagerOrganizationId { get; set; }

    private bool IsOverdue { get; set; }

    public decimal TotalAmount { get; set; }
    public decimal AmountPaid { get; set; }
    public Guid CustomerId { get; set; }
    public Guid CustomerOrganizationId { get; set; }
}