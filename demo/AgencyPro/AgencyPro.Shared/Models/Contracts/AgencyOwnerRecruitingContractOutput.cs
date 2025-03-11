namespace AgencyPro.Shared.Models.Contracts
{
    public class AgencyOwnerRecruitingContractOutput : RecruitingContractOutput
    {
        public override Guid TargetOrganizationId => RecruiterOrganizationId;
        public override int RecruitingNumber { get; set; }
        public override decimal MaxRecruiterWeekly { get; set; }
        public override decimal MaxRecruitingAgencyWeekly { get; set; }
        public override Guid RecruiterId { get; set; }
        public override Guid RecruiterOrganizationId { get; set; }
        public override decimal RecruiterStream { get; set; }
        public override decimal RecruitingAgencyStream { get; set; }
        public override Guid AccountManagerOrganizationId { get; set; }
        public override string AccountManagerOrganizationName { get; set; } = null!;
        public override string AccountManagerImageUrl { get; set; } = null!;
        public override string AccountManagerOrganizationImageUrl { get; set; } = null!;
        public override string ContractorName { get; set; } = null!;
        public override string ContractorEmail { get; set; } = null!;
        public override string ContractorPhoneNumber { get; set; } = null!;
        public override string ContractorOrganizationName { get; set; } = null!;
        public override string ContractorImageUrl { get; set; } = null!;
        public override string ContractorOrganizationImageUrl { get; set; } = null!;
        public override string CustomerOrganizationName { get; set; } = null!;
        public override string CustomerOrganizationImageUrl { get; set; } = null!;
        public override Guid CustomerOrganizationId { get; set; }
        public override string RecruiterName { get; set; } = null!;
        public override string RecruiterEmail { get; set; } = null!;
        public override string RecruiterPhoneNumber { get; set; } = null!;
        public override string RecruiterImageUrl { get; set; } = null!;
        public override string RecruiterOrganizationName { get; set; } = null!;
        public override string RecruiterOrganizationImageUrl { get; set; } = null!;
        public override decimal TotalHoursLogged { get; set; }
        public override decimal TotalApprovedHours { get; set; }

        public override Guid TargetPersonId => RecruitingOrganizationOwnerId;
    }
}