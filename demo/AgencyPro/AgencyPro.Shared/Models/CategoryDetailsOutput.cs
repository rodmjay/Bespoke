namespace AgencyPro.Shared.Models
{
    public class CategoryDetailsOutput : CategoryOutput
    {
        public List<OrganizationOutput> Organizations { get; set; }
    }
}