namespace AgencyPro.Shared.Models
{
    public class MarketingAgencyOwnerTimeMatrixComposedOutput
    {
        public ICollection<MarketingAgencyOwnerTimeMatrixOutput> Matrix { get; set; }
        public ICollection<AgencyOwnerOrganizationMarketerOutput> Marketers { get; set; }
    }
}