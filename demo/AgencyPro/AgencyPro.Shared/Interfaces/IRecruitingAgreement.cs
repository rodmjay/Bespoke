namespace AgencyPro.Shared.Interfaces;

public interface IRecruitingAgreement
{
    Guid ProviderOrganizationId { get; set; }
    Guid RecruitingOrganizationId { get; set; }
    decimal RecruiterStream { get; set; }
    AgreementStatus Status { get; set; }
    bool InitiatedByProvider { get; set; }
    decimal RecruitingAgencyBonus { get; set; }
    decimal RecruiterBonus { get; set; }
    decimal RecruitingAgencyStream { get; set; }
}