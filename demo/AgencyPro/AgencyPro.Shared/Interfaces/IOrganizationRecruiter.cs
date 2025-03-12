namespace AgencyPro.Shared.Interfaces;

public interface IOrganizationRecruiter
{
    Guid OrganizationId { get; }
    Guid RecruiterId { get; }
}