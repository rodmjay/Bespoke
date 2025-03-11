using AgencyPro.Shared.Filters;

namespace AgencyPro.Shared.Models
{
    public class WorkOrderFilters : CommonFilters
    {
        public Guid? AccountManagerOrganizationId { get; set; }
    }
}