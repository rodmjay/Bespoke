using System.ComponentModel.DataAnnotations;

namespace AgencyPro.Shared.Models;

public class TimeSegmentRejectModel
{
    [Required] public string Reason { get; set; }
}