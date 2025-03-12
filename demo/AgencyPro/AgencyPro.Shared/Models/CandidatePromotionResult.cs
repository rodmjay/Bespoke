namespace AgencyPro.Shared.Models;

public class CandidatePromotionResult : Result
{
    public Guid? CandidateId { get; set; }
    public Guid? PersonId { get; set; }
}