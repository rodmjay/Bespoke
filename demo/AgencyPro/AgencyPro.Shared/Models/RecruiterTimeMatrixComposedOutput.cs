using AgencyPro.Shared.Models.Contracts;

namespace AgencyPro.Shared.Models;

public class RecruiterTimeMatrixComposedOutput
{
    public ICollection<RecruiterTimeMatrixOutput> Matrix { get; set; }

    public ICollection<RecruiterOrganizationAccountManagerOutput> AccountManagers { get; set; }
    public ICollection<RecruiterOrganizationContractorOutput> Contractors { get; set; }
    public ICollection<RecruiterContractOutput> Contracts { get; set; }
}