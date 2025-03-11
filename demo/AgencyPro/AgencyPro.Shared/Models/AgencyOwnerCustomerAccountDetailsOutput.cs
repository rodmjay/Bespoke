namespace AgencyPro.Shared.Models
{
    public class AgencyOwnerCustomerAccountDetailsOutput : AgencyOwnerCustomerAccountOutput
    {
        public ICollection<AgencyOwnerProjectOutput> Projects { get; set; }
        public ICollection<AgencyOwnerProviderContractOutput> Contracts { get; set; }
        public ICollection<AgencyOwnerProjectInvoiceOutput> Invoices { get; set; }
        public ICollection<ProviderWorkOrderOutput> WorkOrders { get; set; }
        public ICollection<CommentOutput> Comments { get; set; }
        public Dictionary<DateTimeOffset, AccountStatus> StatusTransitions { get; set; }
        public ICollection<PaymentTermOutput> AvailablePaymentTerms { get; set; }
        public IDictionary<ProjectStatus, int> ProjectSummary { get; set; }
        public IDictionary<OrderStatus, int> WorkOrderSummary { get; set; }
        public IDictionary<string,int> InvoiceSummary { get; set; }
        public IDictionary<ContractStatus, int> ContractSummary { get; set; }
    }
}