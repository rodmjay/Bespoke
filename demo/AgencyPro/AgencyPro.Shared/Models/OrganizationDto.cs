using System.ComponentModel.DataAnnotations;
using AgencyPro.Shared.Options;

namespace AgencyPro.Shared.Models
{
    public class OrganizationDto : IOrganization
    {
        public virtual string CategoryName { get; set; }

        public virtual Guid Id { get; set; }

        public int CategoryId { get; set; }
        public virtual OrganizationType OrganizationType { get; set; }
        public virtual DateTimeOffset Created { get; set; }
        public virtual DateTimeOffset Updated { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public virtual string ImageUrl { get; set; }

        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public string TertiaryColor { get; set; }
        [Required] public virtual string Name { get; set; }

        public virtual string Description { get; set; }
        public string Iso2 { get; set; }
        public string ProvinceState { get; set; }

    }
}