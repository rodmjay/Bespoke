namespace AgencyPro.Shared.Models
{
    public class RecruiterOrganizationOutput : RecruitingOrganizationOutput
    {
       
        [JsonIgnore]
        public override decimal RecruitingAgencyStream { get; set; }
    }
}