namespace AgencyPro.Shared.Models
{
    public class ProjectManagerOrganizationAccountManagerOutput
        : OrganizationAccountManagerOutput
    {
        [JsonIgnore]
        public override decimal AccountManagerStream { get; set; }

        [JsonIgnore]
        public override PersonStatus Status { get; set; }
    }
}