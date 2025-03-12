namespace AgencyPro.Shared.Options;

public class OrganizationProjectManagerInput : IOrganizationProjectManager
{
    public virtual decimal ProjectManagerStream { get; set; }

    public virtual Guid ProjectManagerId { get; set; }
    public virtual Guid OrganizationId { get; set; }
}