namespace AgencyPro.Shared.Models
{
    public class ProviderAgencyOwnerRecruitingOrganizationOutput : RecruitingOrganizationOutput
    {
        [JsonIgnore]
        public override Guid DefaultRecruiterId { get; set; }

        [JsonIgnore]
        public override decimal RecruiterStream { get; set; }

        [JsonIgnore]
        public override decimal RecruitingAgencyStream { get; set; }

        public decimal RecruitingStream => RecruiterStream + RecruitingAgencyStream;

    }
}