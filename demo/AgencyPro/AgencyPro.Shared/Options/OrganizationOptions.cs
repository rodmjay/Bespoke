using System.ComponentModel.DataAnnotations;

namespace AgencyPro.Shared.Options
{
    public class OrganizationOptions
    {
        [Required] public virtual string Name { get; set; } = null!;

        public virtual string Description { get; set; } = null!;
        public string Iso2 { get; set; } = null!;
    }
}