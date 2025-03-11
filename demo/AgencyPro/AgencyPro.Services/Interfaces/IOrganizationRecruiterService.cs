using AgencyPro.Domain.Entities;
using AgencyPro.Shared.Models;

namespace AgencyPro.Services.Interfaces
{
    public interface IOrganizationRecruiterService
        : IService<OrganizationRecruiter>,
            IOrganizationRoleService<OrganizationRecruiterInput, OrganizationRecruiterOutput,
                IOrganizationRecruiter, RecruiterFilters, RecruiterOrganizationOutput, RecruiterCounts>
    {
      
    }
}