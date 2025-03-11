namespace AgencyPro.Shared.Models
{
    public class CustomerContractDetailsOutput : CustomerContractOutput
    {
        public ICollection<CustomerTimeEntryOutput> ApprovedTimeEntries { get; set; }
        public ICollection<CustomerStoryOutput> Stories { get; set; }
        public ICollection<CommentOutput> Comments { get; set; }
    }
}