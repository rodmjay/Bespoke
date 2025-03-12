namespace AgencyPro.Shared.Interfaces;

public interface IOrganizationAccountManager
{
    Guid OrganizationId { get; }
    Guid AccountManagerId { get; }
}