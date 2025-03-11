using AgencyPro.Shared.Models;

namespace AgencyPro.Shared.Options
{
    public class RecruitingOrganizationInput : RecruitingOrganizationUpgradeInput
    {
        public virtual Guid DefaultRecruiterId { get; set; }



    }
}