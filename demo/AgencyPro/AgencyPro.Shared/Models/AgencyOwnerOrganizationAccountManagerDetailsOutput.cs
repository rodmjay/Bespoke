namespace AgencyPro.Shared.Models
{
    public class AgencyOwnerOrganizationAccountManagerDetailsOutput : OrganizationAccountManagerStatistics
    {
        public virtual IList<AgencyOwnerCustomerAccountOutput> Accounts { get; set; }
        public virtual IList<AgencyOwnerLeadOutput> Leads { get; set; }


    }
}