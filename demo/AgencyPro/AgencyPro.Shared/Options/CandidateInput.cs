using System.ComponentModel.DataAnnotations;

namespace AgencyPro.Shared.Options
{
    public class CandidateInput
    {
        [Required] public virtual string FirstName { get; set; } = null!;

        [Required]
        public virtual string LastName { get; set; } = null!;

        [Required]
        [DataType(DataType.EmailAddress)]
        public virtual string EmailAddress { get; set; } = null!;

        [Required]
        public virtual string PhoneNumber { get; set; } = null!;

        public virtual bool IsContacted { get; set; }

        public virtual string Description { get; set; } = null!;
        public virtual string ReferralCode { get; set; } = null!;
        public virtual string Iso2 { get; set; } = null!;
        public virtual string ProvinceState { get; set; } = null!;
    }
}