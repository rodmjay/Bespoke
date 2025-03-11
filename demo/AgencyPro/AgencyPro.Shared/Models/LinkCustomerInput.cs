using System.ComponentModel.DataAnnotations;

namespace AgencyPro.Shared.Models
{
    public class LinkCustomerInput
    {
         public Guid AccountManagerId { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        public Guid AccountManagerOrganizationId { get; set; }

        public int? PaymentTermId { get; set; }
    }
}