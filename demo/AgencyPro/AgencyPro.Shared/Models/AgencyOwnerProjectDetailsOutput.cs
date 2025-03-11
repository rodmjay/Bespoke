using AgencyPro.Shared.Models.Contracts;

namespace AgencyPro.Shared.Models
{
    public class AgencyOwnerProjectDetailsOutput : AgencyOwnerProjectOutput
    {
        public AgencyOwnerFixedPriceProposalModel Proposal { get; set; }
        public ICollection<AgencyOwnerProviderContractOutput> Contracts { get; set; }
        public ICollection<AgencyOwnerStoryOutput> Stories { get; set; }
        public ICollection<AgencyOwnerProjectInvoiceOutput> Invoices { get; set; }
        public ICollection<CommentOutput> Comments { get; set; }

        public Dictionary<DateTimeOffset, ProjectStatus> StatusTransitions { get; set; }
        public IDictionary<TimeStatus, int> TimeEntryStatus { get; set; }
        public IDictionary<StoryStatus, int> StoryStatus { get; set; }
        public IDictionary<ContractStatus, int> ContractStatus { get; set; }

        public ICollection<BillingCategoryOutput> AvailableBillingCategories { get; set; }
        public ICollection<PaymentTermOutput> AvailablePaymentTerms { get; set; }
        public ICollection<int> BillingCategoryIds { get; set; }
    }
}