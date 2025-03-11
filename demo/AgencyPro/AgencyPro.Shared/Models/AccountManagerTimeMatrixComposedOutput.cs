namespace AgencyPro.Shared.Models
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