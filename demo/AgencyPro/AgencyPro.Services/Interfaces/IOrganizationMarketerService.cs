namespace AgencyPro.Services.Interfaces
{
    public interface IOrganizationMarketerService : IService<OrganizationMarketer>,
        IOrganizationRoleService<OrganizationMarketerInput, 
            OrganizationMarketerOutput, IOrganizationMarketer, MarketerFilters, MarketerOrganizationOutput, MarketerCounts>
    {
       
        Task<T> GetMarketerForProject<T>(Guid inputProjectId)   
            where T : OrganizationMarketerOutput;
        

        Task<T> GetMarketerOrDefault<T>(Guid? organizationId, Guid? marketerId, string referralCode)
            where T : OrganizationMarketerOutput;
    }
}