namespace AgencyPro.Domain.Entities
{
    public class LeadMatrix : ILeadMatrix
    {
        public OrganizationMarketer OrganizationMarketer { get; set; }

        public Guid MarketerId { get; set; }
        public Guid MarketerOrganizationId { get; set; }
        public int Count { get; set; }
        public LeadStatus Status { get; set; }
        public DateTime Date { get; set; }
    }
}