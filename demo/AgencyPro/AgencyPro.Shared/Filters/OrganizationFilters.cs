namespace AgencyPro.Shared.Filters;

public class OrganizationFilters
{
    public static readonly OrganizationFilters NoFilter = new();

    public Guid[] Skills { get; set; }

    public int? CategoryId { get; set; }
}