namespace AgencyPro.Shared.Filters;

public class AccountManagerFilters
{
    public static readonly AccountManagerFilters NoFilter = new();
    public Guid? CustomerId { get; set; }
}