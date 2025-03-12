namespace AgencyPro.Shared.Interfaces;

public interface IOrganizationMarketer
{
    Guid MarketerId { get; set; }
    Guid OrganizationId { get; set; }
}