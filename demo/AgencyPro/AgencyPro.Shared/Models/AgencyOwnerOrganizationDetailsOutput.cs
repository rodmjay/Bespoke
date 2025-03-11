namespace AgencyPro.Shared.Models
{
    public class AgencyOwnerOrganizationDetailsOutput : OrganizationOutput
    {
        public AgencyOwnerProviderOrganizationDetailsOutput ProviderOrganizationDetails { get; set; }
        public AgencyOwnerMarketingOrganizationDetailsOutput MarketingOrganizationDetails { get; set; }
        public AgencyOwnerRecruitingOrganizationDetailsOutput RecruitingOrganizationDetails { get; set; }

        public FinancialAccountOutput FinancialAccount { get; set; }
        public BuyerAccountOutput BuyerAccount { get; set; }
    }
}