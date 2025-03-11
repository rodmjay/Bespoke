namespace AgencyPro.Shared.Options
{
    public class OrganizationRecruiterInput : IOrganizationRecruiter
    {
        public virtual decimal RecruiterStream { get; set; }

        public virtual decimal RecruiterBonus { get; set; }

        public Guid RecruiterId { get; set; }

        public Guid OrganizationId { get; set; }
    }
}