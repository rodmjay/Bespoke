namespace AgencyPro.Shared.Interfaces
{
    public interface IOrganizationContractor
    {
        Guid OrganizationId { get; }
        Guid ContractorId { get; }
    }
}