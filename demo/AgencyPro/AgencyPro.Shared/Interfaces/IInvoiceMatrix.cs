namespace AgencyPro.Shared.Interfaces
{
    public interface IInvoiceMatrix
    {
        Guid CustomerId { get; set; }
        Guid CustomerOrganizationId { get; set; }
    }
}