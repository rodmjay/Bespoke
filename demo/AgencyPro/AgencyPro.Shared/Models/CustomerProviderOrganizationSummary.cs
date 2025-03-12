namespace AgencyPro.Shared.Models;

public class CustomerProviderOrganizationSummary
{
    public ICollection<CustomerProviderOrganizationOutput> Organizations { get; set; }

    public ICollection<SkillOutput> AvailableSkills { get; set; }
    public ICollection<CategoryOutput> AvailableCategories { get; set; }
}