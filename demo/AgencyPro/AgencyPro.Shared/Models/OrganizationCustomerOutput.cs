using AgencyPro.Shared.Options;

namespace AgencyPro.Shared.Models;

public class OrganizationCustomerOutput : OrganizationCustomerInput, IOrganizationCustomer, IAgencyOwner,
    IMarketingAgencyOwner, IRecruitingAgencyOwner, IProviderAgencyOwner
{
    public virtual string OrganizationImageUrl { get; set; }
    public virtual string OrganizationName { get; set; }
    public virtual string DisplayName { get; set; }
    public virtual string ImageUrl { get; set; }

    [JsonIgnore] public string StripeCustomerId { get; }

    public bool IsMarketingOwner { get; set; }
    public bool IsRecruitingOwner { get; set; }
    public bool IsProviderOwner { get; set; }
}