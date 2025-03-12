using AgencyPro.Shared.Models.People;

namespace AgencyPro.Shared.Models
{
    public class AccountManagerOrganizationMembershipDetailsOutput : AccountManagerOrganizationMembershipOutput
    {
        public AccountManagerOrganizationContractorOutput Contractor { get; set; }
        public AccountManagerOrganizationMarketerOutput Marketer { get; set; }
        public AccountManagerOrganizationRecruiterOutput Recruiter { get; set; }
        public AccountManagerOrganizationProjectManagerOutput ProjectManager { get; set; }
        public AccountManagerOrganizationAccountManagerOutput AccountManager { get; set; }
    }
}