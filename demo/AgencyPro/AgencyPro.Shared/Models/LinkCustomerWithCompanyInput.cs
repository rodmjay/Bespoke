using System.ComponentModel.DataAnnotations;

namespace AgencyPro.Shared.Models
{
    public class LinkCustomerWithCompanyInput : LinkCustomerInput
    {
        [Required] public string CompanyName { get; set; }

        public bool AutoApproveTimeEntries { get; set; }

    }
}