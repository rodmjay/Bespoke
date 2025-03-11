namespace AgencyPro.Shared.Models
{
    public class OrganizationMarketerStatistics : OrganizationMarketerOutput
    {
        public int TotalLeads { get; set; }
        public int TotalContracts { get; set; }
        public int TotalCustomers { get; set; }
    }
}