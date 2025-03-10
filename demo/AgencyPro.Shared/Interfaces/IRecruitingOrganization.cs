namespace AgencyPro.Shared.Interfaces
{
    public interface IRecruitingOrganization
    {
        decimal RecruiterStream { get; set; }
        decimal RecruitingAgencyStream { get; set; }
        Guid DefaultRecruiterId { get; set; }
    }
}