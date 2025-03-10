namespace AgencyPro.Shared.Interfaces
{
    public interface IOrganizationPersonTarget
    {
        Guid TargetOrganizationId { get; }
        Guid TargetPersonId { get;  }
    }
}