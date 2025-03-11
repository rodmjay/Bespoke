using System;

namespace AgencyPro.Shared.Options
{
    public class WorkOrderInput
    {
        public Guid AccountManagerId { get; set; }
        public Guid AccountManagerOrganizationId { get; set; }
        public string Description { get; set; }
        public bool IsDraft { get; set; }
    }
}