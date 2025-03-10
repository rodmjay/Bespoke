namespace AgencyPro.Shared.Interfaces
{
    public interface IOrganizationProjectManager
    {
        Guid ProjectManagerId { get; set; }
        Guid OrganizationId { get; set; }
    }
}