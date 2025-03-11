namespace AgencyPro.Shared.Models
{
    public class ProviderContractorOutput : OrganizationContractorOutput
    {
        [JsonIgnore] public override decimal ContractorStream { get; set; }
        [JsonIgnore] public override bool IsFeatured { get; set; }
    }
}