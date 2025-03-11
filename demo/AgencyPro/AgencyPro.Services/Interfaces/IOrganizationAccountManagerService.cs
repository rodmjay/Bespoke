using AgencyPro.Shared.Models.Organizations;

namespace AgencyPro.Services.Interfaces
{
    public interface IOrganizationAccountManagerService : IService<OrganizationAccountManager>,
        IOrganizationRoleService<OrganizationAccountManagerInput, OrganizationAccountManagerOutput,
            IOrganizationAccountManager, AccountManagerFilters, AccountManagerOrganizationOutput, AccountManagerCounts>
    {
     
        Task<T> GetAccountManagerForProject<T>(Guid projectId) 
            where T : OrganizationAccountManagerOutput;

        Task<T> GetAccountManagerOrDefault<T>(Guid organizationId, Guid? accountManager)
            where T : OrganizationAccountManagerOutput;
    }
}