namespace AgencyPro.Shared.Options;

public class OrganizationAccountManagerInput : IOrganizationAccountManager
{
    public virtual decimal AccountManagerStream { get; set; }
    public virtual Guid AccountManagerId { get; set; }
    public virtual Guid OrganizationId { get; set; }
}