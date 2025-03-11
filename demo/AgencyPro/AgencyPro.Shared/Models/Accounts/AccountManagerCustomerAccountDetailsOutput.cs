using AgencyPro.Shared.Models.Contracts;
using AgencyPro.Shared.Models.Invoices;
using AgencyPro.Shared.Models.Projects;

namespace AgencyPro.Shared.Models.Accounts
{
    public class AccountManagerCustomerAccountDetailsOutput : AccountManagerCustomerAccountOutput
    {
        public ICollection<AccountManagerProjectOutput> Projects { get; set; }
        public ICollection<AccountManagerContractOutput> Contracts { get; set; }
        public ICollection<AccountManagerProjectInvoiceOutput> Invoices { get; set; }
        public ICollection<ProviderWorkOrderOutput> WorkOrders { get; set; }
        public ICollection<CommentOutput> Comments { get; set; }
        public Dictionary<DateTimeOffset, AccountStatus> StatusTransitions { get; set; }
        public IDictionary<ProjectStatus, int> ProjectSummary { get; set; }
        public IDictionary<OrderStatus, int> WorkOrderSummary { get; set; }
        public IDictionary<string, int> InvoiceSummary { get; set; }
        public IDictionary<ContractStatus, int> ContractSummary { get; set; }

    }
}