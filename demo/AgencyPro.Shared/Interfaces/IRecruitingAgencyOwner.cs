namespace AgencyPro.Shared.Interfaces
{
    public interface IRecruitingAgencyOwner
    {
        Guid OrganizationId { get; }
        Guid CustomerId { get; }
    }
}