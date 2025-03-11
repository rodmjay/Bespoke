namespace AgencyPro.Services.Interfaces
{
    public interface IOrganizationRecruiterService
        : IService<OrganizationRecruiter>,
            IOrganizationRoleService<OrganizationRecruiterInput, OrganizationRecruiterOutput,
                IOrganizationRecruiter, RecruiterFilters, RecruiterOrganizationOutput, RecruiterCounts>
    {
      
    }
}