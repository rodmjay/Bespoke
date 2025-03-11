namespace AgencyPro.Shared.Models
{
    public class MarketerLeadMatrixOutput : LeadMatrixOutput
    {
        [JsonIgnore]
        public override Guid MarketerId { get; set; }

        [JsonIgnore]
        public override Guid MarketerOrganizationId { get; set; }
    }
}