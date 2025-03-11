namespace AgencyPro.Services.Interfaces
{
    public interface IOrganizationContractorService : IService<OrganizationContractor>,
        IOrganizationRoleService<OrganizationContractorInput,
            OrganizationContractorOutput, IOrganizationContractor, ContractorFilters, ContractorOrganizationOutput, ContractorCounts>
    {
        Task<List<T>> GetFeaturedContractors<T>(Guid organizationId)
            where T : OrganizationContractorOutput;
        
        Task<T> UpdateRecruiter<T>(IAgencyOwner agencyOwner, Guid contractorId, UpdateContractorRecruiterInput input) where T : AgencyOwnerOrganizationContractorOutput;
    }
}