namespace AgencyPro.Shared.Models
{
    public class AccountManagerOrganizationAccountManagerDetailsOutput : OrganizationAccountManagerStatistics
    {
        public virtual IList<AccountManagerCustomerAccountOutput> Accounts { get; set; }
        public virtual IList<AccountManagerLeadOutput> Leads { get; set; }
    }
}