namespace AgencyPro.Shared.Models;

public sealed class CustomerOrganizationContractorOutput :
    OrganizationContractorOutput
{
    [JsonIgnore] public override decimal ContractorStream { get; set; }
    [JsonIgnore] public override bool IsFeatured { get; set; }
}