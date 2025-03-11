using System.ComponentModel.DataAnnotations;

namespace AgencyPro.Shared.Options
{
    public class UpdateRecruitingContractInput
    {

        [Range(0, 100)]
        [DataType(DataType.Currency)]
        public virtual decimal? RecruiterStream { get; set; }


        [Range(0, 100)]
        [DataType(DataType.Currency)]
        public virtual decimal? RecruitingAgencyStream { get; set; }

    }
}