using AgencyPro.Shared.Models.Contracts;
using AgencyPro.Shared.Models.People;
using AgencyPro.Shared.Models.Projects;

namespace AgencyPro.Shared.Models.TimeTracking
{
    public class AccountManagerTimeMatrixComposedOutput
    {
        public ICollection<AccountManagerTimeMatrixOutput> Matrix { get; set; }


        public ICollection<AccountManagerOrganizationProjectManagerOutput> ProjectManagers { get; set; }
        public ICollection<AccountManagerOrganizationCustomerOutput> Customers { get; set; }
        public ICollection<AccountManagerOrganizationContractorOutput> Contractors { get; set; }
        public ICollection<AccountManagerContractOutput> Contracts { get; set; }
        public ICollection<AccountManagerProjectOutput> Projects { get; set; }
        public ICollection<AccountManagerStoryOutput> Stories { get; set; }
    }
}