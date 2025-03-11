using AgencyPro.Shared.Options;

namespace AgencyPro.Shared.Models
{
    public class OrganizationRecruiterOutput : OrganizationRecruiterInput
    {
        public virtual string DisplayName { get; set; }
        public virtual string ImageUrl { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Email { get; set; }
        public virtual bool IsDefault { get; set; }
        public virtual PersonStatus Status { get; set; }
    }
}