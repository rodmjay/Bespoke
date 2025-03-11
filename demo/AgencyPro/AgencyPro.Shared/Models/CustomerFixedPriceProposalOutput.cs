namespace AgencyPro.Shared.Models
{
    public class CustomerFixedPriceProposalOutput : FixedPriceProposalOutput
    {
        [JsonIgnore]
        public override decimal OtherPercentBasis { get; set; }

        public override Guid TargetOrganizationId => this.CustomerOrganizationId;
        public override Guid TargetPersonId => this.CustomerId;
    }
}