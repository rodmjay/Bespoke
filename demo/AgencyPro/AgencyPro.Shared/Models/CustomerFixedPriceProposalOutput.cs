namespace AgencyPro.Shared.Models;

public class CustomerFixedPriceProposalOutput : FixedPriceProposalOutput
{
    [JsonIgnore] public override decimal OtherPercentBasis { get; set; }

    public override Guid TargetOrganizationId => CustomerOrganizationId;
    public override Guid TargetPersonId => CustomerId;
}