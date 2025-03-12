namespace AgencyPro.Shared.Models;

public class RecruitingAgencyOwnerTimeMatrixComposedOutput
{
    public ICollection<RecruitingAgencyOwnerTimeMatrixOutput> Matrix { get; set; }
    public ICollection<AgencyOwnerOrganizationRecruiterOutput> Recruiters { get; set; }
}