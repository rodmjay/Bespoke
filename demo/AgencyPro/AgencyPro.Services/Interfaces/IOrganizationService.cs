using AgencyPro.Shared.Models.Organizations;
using Bespoke.Shared.Common;
using Microsoft.AspNetCore.Http;
using OneOf;
namespace AgencyPro.Services.Interfaces
{
    public interface IOrganizationService : IService<Organization>
    {
        Task<OneOf<OrganizationDto, Result>> UpgradeOrganization(IOrganizationCustomer customer, OrganizationUpgradeInput input);

        Task<OneOf<OrganizationDto, Result>> UpgradeOrganization(IAgencyOwner agencyOwner,
            MarketingOrganizationUpgradeInput input);
        Task<OneOf<OrganizationDto, Result>> UpgradeOrganization(IAgencyOwner agencyOwner,
            ProviderOrganizationUpgradeInput input);
        Task<OneOf<OrganizationDto, Result>> UpgradeOrganization(IAgencyOwner agencyOwner,
            RecruitingOrganizationUpgradeInput input);

        Task<OneOf<OrganizationDto, Result>> UpdateOrganization(IAgencyOwner agencyOwner, OrganizationUpdateInput input);
        Task<OneOf<OrganizationDto, Result>> UpdateOrganization(IMarketingAgencyOwner agencyOwner, MarketingOrganizationInput input);
        Task<OneOf<OrganizationDto, Result>> UpdateOrganization(IProviderAgencyOwner agencyOwner, ProviderOrganizationInput input);
        Task<OneOf<OrganizationDto, Result>> UpdateOrganization(IRecruitingAgencyOwner agencyOwner, RecruitingOrganizationInput input);

        //Task<T> UpdateMarketingOrganization<T>(IAgencyOwner agencyOwner, MarketingOrganizationUpdateInput input) where T : MarketingAgencyOwnerOrganizationOutput;
        //Task<T> UpdateProviderOrganization<T>(IAgencyOwner agencyOwner, ProviderOrganizationUpdateInput input) where T : ProviderAgencyOwnerOrganizationOutput;
        Task<OneOf<OrganizationDto, Result>> UpdateBuyerOrganization(IOrganizationCustomer cu, OrganizationUpdateInput input);

        Task<OneOf<OrganizationDto, Result>> UpdateOrganizationPic(IAgencyOwner agencyOwner, IFormFile image);
        Task<OneOf<OrganizationDto, Result>> UpdateOrganizationPic(IOrganizationCustomer customerOrg, IFormFile image);

        Task<OneOf<OrganizationDto, Result>> CreateOrganization(IAgencyOwner ao, OrganizationCreateInput input, Guid customerId);
        Task<OneOf<OrganizationDto, Result>> CreateOrganization(ICustomer cu, OrganizationCreateInput input);
        Task<OneOf<OrganizationDto, Result>> CreateOrganization(IOrganizationAccountManager am, OrganizationCreateInput input, Guid customerId);
        
        Task<OrganizationDto> Get(Guid organizationId);
        Task<T> GetOrganization<T>(Guid organizationId) where T : OrganizationDto;
        Task DeleteOrganization(Guid organizationId);

        Task<T> GetOrganization<T>(IOrganizationAccountManager am) where T : AccountManagerOrganizationOutput;
        Task<T> GetOrganization<T>(IOrganizationProjectManager pm) where T : ProjectManagerOrganizationOutput;
        Task<T> GetOrganization<T>(IOrganizationCustomer cu) where T : CustomerOrganizationOutput;
        Task<T> GetOrganization<T>(IOrganizationContractor co) where T : ContractorOrganizationOutput;
        Task<T> GetOrganization<T>(IOrganizationMarketer ma) where T : MarketerOrganizationOutput;
        Task<T> GetOrganization<T>(IOrganizationRecruiter re) where T : RecruiterOrganizationOutput;
        Task<T> GetOrganization<T>(IAgencyOwner ao) where T : OrganizationDto;

        Task<T> GetProviderOrganization<T>(IOrganizationCustomer cu, Guid organizationId) where T : CustomerProviderOrganizationOutput;
        Task<List<T>> GetProviderOrganizations<T>(IOrganizationCustomer cu, OrganizationFilters filters) where T : CustomerProviderOrganizationOutput;
        Task<CustomerProviderOrganizationSummary> GetProviderOrganizationSummary(IOrganizationCustomer cu, OrganizationFilters filters);

        Task<List<T>> GetOrganizations<T>(Guid personId) where T : OrganizationDto;
        Task<List<T>> GetOrganizations<T>(IMarketer marketer) where T : MarketerOrganizationOutput;
        Task<List<T>> GetOrganizations<T>(IRecruiter marketer) where T : RecruiterOrganizationOutput;

        Task<List<AffiliationOutput>> GetAffiliationsForPerson(Guid userUserId);
        Task<AffiliationOutput> GetAffiliationsForPerson(Guid personId, Guid organizationId);


        Task<AgencyOwnerCounts> GetCounts(IAgencyOwner agencyOwner);
        Task<AgencyOwnerMarketingOrganizationDetailsOutput> GetMarketingDetails(IMarketingAgencyOwner agencyOwner);
        Task<AgencyOwnerRecruitingOrganizationDetailsOutput> GetRecruitingDetails(IRecruitingAgencyOwner agencyOwner);
        Task<AgencyOwnerProviderOrganizationDetailsOutput> GetProviderDetails(IProviderAgencyOwner agencyOwner);
    }
}