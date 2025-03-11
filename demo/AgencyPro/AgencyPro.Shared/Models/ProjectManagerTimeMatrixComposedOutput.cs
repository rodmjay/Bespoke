namespace AgencyPro.Shared.Models
{
    public class ProjectManagerTimeMatrixComposedOutput
    {
        public ICollection<ProjectManagerTimeMatrixOutput> Matrix { get; set; }

        public ICollection<ProjectManagerOrganizationCustomerOutput> Customers { get; set; }
        public ICollection<ProjectManagerOrganizationAccountManagerOutput> AccountManagers { get; set; }
        public ICollection<ProjectManagerOrganizationContractorOutput> Contractors { get; set; }
        public ICollection<ProjectManagerContractOutput> Contracts { get; set; }
        public ICollection<ProjectManagerProjectOutput> Projects { get; set; }
        public ICollection<ProjectManagerStoryOutput> Stories { get; set; }
    }
}