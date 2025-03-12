namespace AgencyPro.Shared.Models;

public class LeadMatrixFilters
{
    public static readonly LeadMatrixFilters NoFilter = new();

    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public Guid? MarketerId { get; set; }
    public Guid? MarketerOrganizationId { get; set; }
}