namespace AgencyPro.Shared.Models;

public class AgreementResult : Result
{
    public Guid? MarketingOrganizationId { get; set; }
    public Guid? ProviderOrganizationId { get; set; }
    public Guid? RecruitingOrganizationId { get; set; }
}