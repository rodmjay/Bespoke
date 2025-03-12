namespace AgencyPro.Shared.Models;

public sealed class ContractorOrganizationContractorOutput
    : OrganizationContractorOutput
{
    [JsonIgnore] public override bool IsFeatured { get; set; }
}