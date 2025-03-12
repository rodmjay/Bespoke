using AgencyPro.Shared.Models.Accounts;
using AgencyPro.Shared.Models.Leads;

namespace AgencyPro.Shared.Models.People;

public class AccountManagerOrganizationAccountManagerDetailsOutput : OrganizationAccountManagerStatistics
{
    public virtual IList<AccountManagerCustomerAccountOutput> Accounts { get; set; }
    public virtual IList<AccountManagerLeadOutput> Leads { get; set; }
}