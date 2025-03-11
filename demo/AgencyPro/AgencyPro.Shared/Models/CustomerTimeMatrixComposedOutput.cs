using AgencyPro.Shared.Models.Contracts;

namespace AgencyPro.Shared.Models
{
    public class CustomerTimeMatrixComposedOutput
    {
        public ICollection<CustomerTimeMatrixOutput> Matrix { get; set; }

        public ICollection<CustomerOrganizationAccountManagerOutput> AccountManagers { get; set; }
        public ICollection<CustomerOrganizationProjectManagerOutput> ProjectManagers { get; set; }
        public ICollection<CustomerOrganizationCustomerOutput> Customers { get; set; }
        public ICollection<CustomerOrganizationContractorOutput> Contractors { get; set; }
        public ICollection<CustomerContractOutput> Contracts { get; set; }
        public ICollection<CustomerProjectOutput> Projects { get; set; }
        public ICollection<CustomerStoryOutput> Stories { get; set; }
    }
}