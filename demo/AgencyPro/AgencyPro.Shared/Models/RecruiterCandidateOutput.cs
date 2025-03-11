namespace AgencyPro.Shared.Models
{
    public class RecruiterCandidateOutput : CandidateOutput
    {
        [JsonIgnore]
        public override Guid RecruiterId { get; set; }

        [JsonIgnore]
        public override Guid RecruiterOrganizationId { get; set; }

        [JsonIgnore]
        public override string RecruiterOrganizationImageUrl { get; set; } = null!;

        public override Guid TargetOrganizationId => this.RecruiterOrganizationId;
        public override Guid TargetPersonId => this.RecruiterId;


        [JsonIgnore]
        public override string RecruiterImageUrl { get; set; } = null!;

        [JsonIgnore]
        public override string RecruiterName { get; set; } = null!;
        [JsonIgnore]
        public override string RecruiterPhoneNumber { get; set; } = null!;
        [JsonIgnore]
        public override string RecruiterEmail { get; set; } = null!;

        [JsonIgnore]
        public override string RecruiterOrganizationName { get; set; } = null!;

        [JsonIgnore]
        public override Guid? ProjectManagerId { get; set; }

        [JsonIgnore]
        public override string ProjectManagerImageUrl { get; set; } = null!;

        [JsonIgnore]
        public override string ProjectManagerName { get; set; } = null!;

        [JsonIgnore]
        public override string ProjectManagerOrganizationImageUrl { get; set; } = null!;

        [JsonIgnore]
        public override string ProjectManagerOrganizationName { get; set; } = null!;

        [JsonIgnore]
        public override Guid? ProjectManagerOrganizationId { get; set; }

        [JsonIgnore]
        public override decimal RecruitingAgencyStream { get; set; }

        [JsonIgnore]
        public override decimal RecruitingAgencyBonus { get; set; }

        [JsonIgnore]
        public override decimal RecruitingBonus { get; }

        [JsonIgnore]
        public override decimal RecruitingStream { get; }
    }
}