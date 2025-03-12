namespace AgencyPro.Shared.Interfaces;

public interface IMarketingAgencyOwner
{
    Guid OrganizationId { get; }
    Guid CustomerId { get; }
}