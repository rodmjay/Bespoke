namespace AgencyPro.Shared.Filters;

public class ProjectManagerFilters
{
    public static readonly ProjectManagerFilters NoFilter = new();
    public Guid? Acc { get; set; }
}