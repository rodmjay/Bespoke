namespace AgencyPro.Shared.Models;

public class CategoryDetailsOutput : CategoryOutput
{
    public List<OrganizationDto> Organizations { get; set; }
}