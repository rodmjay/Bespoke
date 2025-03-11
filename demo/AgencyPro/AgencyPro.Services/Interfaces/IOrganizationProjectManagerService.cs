namespace AgencyPro.Services.Interfaces
{
    public interface IOrganizationProjectManagerService : IService<OrganizationProjectManager>,
        IOrganizationRoleService<OrganizationProjectManagerInput, OrganizationProjectManagerOutput,
            IOrganizationProjectManager, ProjectManagerFilters, ProjectManagerOrganizationOutput, ProjectManagerCounts>
    {
        Task<T> GetProjectManagerForProject<T>(Guid projectId) where T : OrganizationProjectManagerOutput;
    }
}