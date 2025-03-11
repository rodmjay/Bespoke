namespace AgencyPro.Services.Interfaces
{
    public interface IOrganizationCustomerService : IService<OrganizationCustomer>,
        IOrganizationRoleService<OrganizationCustomerInput,
            OrganizationCustomerOutput, IOrganizationCustomer, CustomerFilters, CustomerOrganizationOutput, CustomerCounts>
    {
        Task<IAgencyOwner> GetAgencyOwner(Guid personId, Guid organizationId);

        Task<List<T>> GetCustomers<T>(IAgencyOwner agencyOwner) where T : OrganizationCustomerOutput;

        Task<T> GetCustomerForProject<T>(Guid projectId)
            where T : OrganizationCustomerOutput;

        Task<List<T>> GetCustomers<T>(IOrganizationAccountManager organizationAccountManager)
            where T: OrganizationCustomerOutput;

        Task<List<T>> GetCustomers<T>(IOrganizationProjectManager projectManager)
            where T : OrganizationCustomerOutput;
        
    }
}