namespace AgencyPro.Shared.Options;

public class OrganizationCustomerInput
{
    public virtual Guid CustomerId { get; set; }
    public virtual Guid OrganizationId { get; set; }
}