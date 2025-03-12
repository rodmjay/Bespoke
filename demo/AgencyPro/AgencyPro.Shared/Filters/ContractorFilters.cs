namespace AgencyPro.Shared.Filters;

public class ContractorFilters
{
    public static readonly ContractorFilters NoFilter = new();
    public Guid? ProjectId { get; set; }
}