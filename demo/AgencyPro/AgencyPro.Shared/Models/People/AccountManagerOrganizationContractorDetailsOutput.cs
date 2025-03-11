using AgencyPro.Shared.Models.Contracts;

namespace AgencyPro.Shared.Models.People
{
    public class AccountManagerOrganizationContractorDetailsOutput
        : OrganizationContractorStatistics
    {
        public virtual IList<ContractorSkillOutput> Skills { get; set; }
        public virtual IList<AccountManagerContractOutput> Contracts { get; set; }
        public virtual IList<AccountManagerStoryOutput> Stories { get; set; }
    }
}