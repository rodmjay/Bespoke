using System.ComponentModel.DataAnnotations;
using AgencyPro.Shared.Models;
using Bespoke.Shared.Helpers;

namespace AgencyPro.Shared.Options
{
    public class OrganizationUpgradeInput : IValidatableObject
    {
        public RecruitingOrganizationUpgradeInput RecruitingOrganizationInput { get; set; }

        public MarketingOrganizationUpgradeInput MarketingOrganizationInput { get; set; }

        public ProviderOrganizationUpgradeInput ProviderOrganizationInput { get; set; }

        public virtual int CategoryId { get; set; }

        public OrganizationType OrganizationType
        {
            get
            {
                var type = OrganizationType.Buyer;

                if (RecruitingOrganizationInput != null) type.Add(OrganizationType.Recruiting);
                if (MarketingOrganizationInput != null) type.Add(OrganizationType.Marketing);
                if (ProviderOrganizationInput != null) type.Add(OrganizationType.Provider);

                return type;
            }
        }

        public bool IsSubscriptionRequired => (int)OrganizationType > (int)OrganizationType.Marketing;

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if ((int)OrganizationType <= 1) yield break;
        }
    }
}