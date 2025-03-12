namespace AgencyPro.Shared.Interfaces;

public interface IProviderAgencyOwner
{
    Guid OrganizationId { get; }
    Guid CustomerId { get; }
}