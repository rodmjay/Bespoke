namespace AgencyPro.Shared.Models.Candidates
{
    public class AgencyOwnerCandidateOutput : CandidateOutput
    {
        [JsonIgnore]
        public override decimal RecruiterStream { get; set; }

        [JsonIgnore]
        public override decimal RecruiterBonus { get; set; }

        [JsonIgnore]
        public override decimal RecruitingAgencyBonus { get; set; }

        public override Guid TargetOrganizationId => ProviderOrganizationId;
        public override Guid TargetPersonId => ProviderOrganizationOwnerId;

        [JsonIgnore]
        public override decimal RecruitingAgencyStream { get; set; }
    }
}