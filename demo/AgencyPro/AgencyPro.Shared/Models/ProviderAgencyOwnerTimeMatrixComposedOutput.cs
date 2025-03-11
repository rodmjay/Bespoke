using AgencyPro.Shared.Models.Contracts;

namespace AgencyPro.Shared.Models
{
    public class ProviderAgencyOwnerTimeMatrixComposedOutput
    {
        public ICollection<ProviderAgencyOwnerTimeMatrixOutput> Matrix { get; set; }

        public ICollection<AgencyOwnerOrganizationAccountManagerOutput> AccountManagers { get; set; }
        public ICollection<AgencyOwnerOrganizationProjectManagerOutput> ProjectManagers { get; set; }
        public ICollection<AgencyOwnerOrganizationCustomerOutput> Customers { get; set; }
        public ICollection<AgencyOwnerOrganizationContractorOutput> Contractors { get; set; }
        public ICollection<AgencyOwnerProviderContractOutput> Contracts { get; set; }
        public ICollection<AgencyOwnerProjectOutput> Projects { get; set; }
        public ICollection<AgencyOwnerStoryOutput> Stories { get; set; }
    }
}