using System.ComponentModel.DataAnnotations;

namespace AgencyPro.Shared.Options
{
    public class OrganizationCreateInput
    {
        [Required] public virtual string Name { get; set; }

        public virtual string Description { get; set; }
        public string Iso2 { get; set; }
        public string ProvinceState { get; set; }
    }
}