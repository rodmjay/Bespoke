namespace AgencyPro.Shared.Models
{
    public class RecruitingAgencyCandidateOutput : CandidateOutput
    {
        [JsonIgnore]
        public override Guid? ProjectManagerId { get; set; }

        [JsonIgnore]
        public override string ProjectManagerImageUrl { get; set; } = null!;

        [JsonIgnore]
        public override string ProjectManagerName { get; set; } = null!;

        [JsonIgnore]
        public override string ProjectManagerOrganizationImageUrl { get; set; } = null!;

        public override Guid TargetOrganizationId => this.RecruiterOrganizationId;
        public override Guid TargetPersonId => this.RecruitingOrganizationOwnerId;

        [JsonIgnore]
        public override string ProjectManagerOrganizationName { get; set; } = null!;

        [JsonIgnore]
        public override Guid? ProjectManagerOrganizationId { get; set; }

    }
}