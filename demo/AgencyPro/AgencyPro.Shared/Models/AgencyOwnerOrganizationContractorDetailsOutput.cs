using AgencyPro.Shared.Models.Contracts;

namespace AgencyPro.Shared.Models
{
    public class AgencyOwnerOrganizationContractorDetailsOutput
        : OrganizationContractorStatistics
    {
        public virtual IList<ContractorSkillOutput> Skills { get; set; }
        public virtual IList<AgencyOwnerProviderContractOutput> Contracts { get; set; }
        public virtual IList<AgencyOwnerStoryOutput> Stories { get; set; }
    }
}