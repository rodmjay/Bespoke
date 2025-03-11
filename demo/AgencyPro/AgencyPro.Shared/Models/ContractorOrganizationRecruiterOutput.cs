namespace AgencyPro.Shared.Models
{
    public class ContractorOrganizationRecruiterOutput
        : OrganizationRecruiterOutput
    {
        [JsonIgnore] public override decimal RecruiterStream { get; set; }
        [JsonIgnore] public override decimal RecruiterBonus { get; set; }
    }
}