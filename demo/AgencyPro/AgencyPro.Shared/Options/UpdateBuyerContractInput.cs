using System.ComponentModel.DataAnnotations;

namespace AgencyPro.Shared.Options;

public class UpdateBuyerContractInput
{
    [Range(1, 100)] public virtual int MaxWeeklyHours { get; set; }
}