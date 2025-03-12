namespace AgencyPro.Shared.Filters;

public class StoryFilters : CommonFilters
{
    public static readonly StoryFilters NoFilter = new();


    public StoryFilters()
    {
        StoryStatus = new StoryStatus[] { };
    }

    public Guid? ProjectId { get; set; }

    public StoryStatus[] StoryStatus { get; set; }
    public Guid? AccountManagerId { get; set; }
    public Guid? CustomerId { get; set; }
    public Guid? ContractorId { get; set; }
    public Guid? ContractorOrganizationId { get; set; }
    public Guid? CustomerOrganizationId { get; set; }
    public Guid? AccountManagerOrganizationId { get; set; }
}