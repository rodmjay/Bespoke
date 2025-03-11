namespace AgencyPro.Shared.Models
{
    public class AgencyOwnerOrganizationPersonDetailsOutput : AgencyOwnerOrganizationPersonOutput
    {
        public AgencyOwnerOrganizationContractorOutput Contractor { get; set; }
        public AgencyOwnerOrganizationMarketerOutput Marketer { get; set; }
        public AgencyOwnerOrganizationRecruiterOutput Recruiter { get; set; }
        public AgencyOwnerOrganizationProjectManagerOutput ProjectManager { get; set; }
        public AgencyOwnerOrganizationAccountManagerOutput AccountManager { get; set; }
    }
}