namespace AgencyPro.Shared.Interfaces;

public interface IOrganizationCustomer
{
    Guid OrganizationId { get; }
    Guid CustomerId { get; }
}