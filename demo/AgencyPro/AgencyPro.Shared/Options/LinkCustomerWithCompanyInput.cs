using System.ComponentModel.DataAnnotations;
using AgencyPro.Shared.Models;

namespace AgencyPro.Shared.Options
{
    public class LinkCustomerWithCompanyInput : LinkCustomerInput
    {
        [Required] public string CompanyName { get; set; }

        public bool AutoApproveTimeEntries { get; set; }

    }
}