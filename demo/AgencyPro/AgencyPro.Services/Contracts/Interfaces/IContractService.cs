using AgencyPro.Shared.Models.Contracts;
using Bespoke.Shared.Common;

namespace AgencyPro.Services.Contracts.Interfaces
{
    public interface IContractService : IService<Contract>
    {
        Task<ContractResult> PauseContract(IOrganizationCustomer cu, Guid contractId);
        Task<ContractResult> PauseContract(IOrganizationContractor co, Guid contractId);
        Task<ContractResult> PauseContract(IProviderAgencyOwner ao, Guid contractId);
        Task<ContractResult> PauseContract(IOrganizationAccountManager am, Guid contractId);

        Task<ContractResult> EndContract(IOrganizationCustomer cu, Guid contractId);
        Task<ContractResult> EndContract(IOrganizationContractor co, Guid contractId);
        Task<ContractResult> EndContract(IProviderAgencyOwner ao, Guid contractId);
        Task<ContractResult> EndContract(IOrganizationAccountManager am, Guid contractId);

        Task<ContractResult> RestartContract(IOrganizationCustomer cu, Guid contractId);
        Task<ContractResult> RestartContract(IOrganizationContractor co, Guid contractId);
        Task<ContractResult> RestartContract(IProviderAgencyOwner ao, Guid contractId);
        Task<ContractResult> RestartContract(IOrganizationAccountManager am, Guid contractId);


        Task<ContractResult> CreateContract(IOrganizationProjectManager pm, ContractInput model);
        Task<ContractResult> CreateContract(IOrganizationAccountManager am, ContractInput model);
        Task<ContractResult> CreateContract(IProviderAgencyOwner ao, ContractInput model);

        Task<ContractResult> DeleteContract(IProviderAgencyOwner agencyOwner, Guid contractId);

        Task<List<T>> GetContracts<T>(Guid[] ids) 
            where T : ContractOutput;

        Task<T> GetContract<T>(Guid id) 
            where T : ContractOutput;

        Task<PackedList<T>> GetContracts<T>(IOrganizationAccountManager am, ContractFilters filters) 
            where T : AccountManagerContractOutput;

        Task<PackedList<T>> GetContracts<T>(IOrganizationProjectManager co, ContractFilters filters) 
            where T : ProjectManagerContractOutput;

        Task<PackedList<T>> GetContracts<T>(IOrganizationCustomer cu, ContractFilters filters) 
            where T : CustomerContractOutput;

        Task<PackedList<T>> GetContracts<T>(IOrganizationContractor co, ContractFilters filters) 
            where T : ContractorContractOutput;

        Task<PackedList<T>> GetProviderContracts<T>(IProviderAgencyOwner ao, ContractFilters filters) 
            where T : AgencyOwnerProviderContractOutput;

        Task<PackedList<T>> GetMarketingContracts<T>(IMarketingAgencyOwner ao, ContractFilters filters)
            where T : AgencyOwnerMarketingContractOutput;

        Task<PackedList<T>> GetRecruitingContracts<T>(IRecruitingAgencyOwner ao, ContractFilters filters)
            where T : AgencyOwnerRecruitingContractOutput;

        Task<T> GetContract<T>(IOrganizationRecruiter re, Guid id)
            where T : RecruiterContractOutput;

        Task<T> GetContract<T>(IOrganizationMarketer ma, Guid id)
            where T : MarketerContractOutput;
        
        Task<T> GetProviderContract<T>(IProviderAgencyOwner ao, Guid contractId) 
            where T : AgencyOwnerProviderContractOutput;

        Task<T> GetMarketingContract<T>(IMarketingAgencyOwner ao, Guid contractId)
            where T : AgencyOwnerMarketingContractOutput;

        Task<T> GetRecruitingContract<T>(IRecruitingAgencyOwner ao, Guid contractId)
            where T : AgencyOwnerRecruitingContractOutput;

        Task<T> GetContract<T>(IOrganizationAccountManager am, Guid contractId) 
            where T : AccountManagerContractOutput;

        Task<T> GetContract<T>(IOrganizationContractor co, Guid contractId) 
            where T : ContractorContractOutput;

        Task<T> GetContract<T>(IOrganizationCustomer cu, Guid contractId) 
            where T : CustomerContractOutput;

        Task<T> GetContract<T>(IOrganizationProjectManager pm, Guid contractId)
            where T : ProjectManagerContractOutput;

        Task<ContractResult> UpdateContract(IOrganizationAccountManager am, Guid contractId,
            UpdateProviderContractInput input);

        Task<ContractResult> UpdateContract(IProviderAgencyOwner ao, Guid contractId,
            UpdateProviderContractInput input);

        Task<ContractResult> UpdateContract(IMarketingAgencyOwner ao, Guid contractId,
            UpdateMarketingContractInput input);

        Task<ContractResult> UpdateContract(IRecruitingAgencyOwner ao, Guid contractId,
            UpdateRecruitingContractInput input);

        Task<ContractResult> UpdateContract(IOrganizationCustomer cu, Guid contractId, UpdateBuyerContractInput model);

        Task<ContractResult> UpdateContract(IOrganizationContractor co, Guid contractId, UpdateProviderContractInput model);
        
        Task<bool> DoesContractAlreadyExist(
            IOrganizationContractor co, IOrganizationCustomer cu, Guid projectId);

        Task<int> GetNextProviderContractId(Guid organizationId);

        Task<List<T>> GetContracts<T>(IProviderAgencyOwner owner, Guid[] uniqueContractIds) 
            where T : AgencyOwnerProviderContractOutput;

        Task<List<T>> GetContracts<T>(IOrganizationAccountManager am, Guid[] uniqueContractIds)
            where T : AccountManagerContractOutput;

        Task<List<T>> GetContracts<T>(IOrganizationProjectManager pm, Guid[] uniqueContractIds)
            where T : ProjectManagerContractOutput;

        Task<List<T>> GetContracts<T>(IOrganizationRecruiter ma, Guid[] uniqueContractIds)
            where T : RecruiterContractOutput;

        Task<List<T>> GetContracts<T>(IOrganizationMarketer ma, Guid[] uniqueContractIds) 
            where T : MarketerContractOutput;

        Task<List<T>> GetContracts<T>(IOrganizationContractor co, Guid[] uniqueContractIds) 
            where T : ContractorContractOutput;

        Task<List<T>> GetContracts<T>(IOrganizationCustomer cu, Guid[] uniqueContractIds) 
            where T : CustomerContractOutput;

        Task<PackedList<T>> GetContracts<T>(IOrganizationMarketer ma, ContractFilters filters)
            where T : MarketerContractOutput;

        Task<PackedList<T>> GetContracts<T>(IOrganizationRecruiter re, ContractFilters filters)
            where T : RecruiterContractOutput;
    }
}