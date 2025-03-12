namespace AgencyPro.Shared.Models;

public class BillingCategoryOutput
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public bool IsEnabled { get; set; }
    public bool IsStoryBucket { get; set; }
    public bool IsPrivate { get; set; }
}