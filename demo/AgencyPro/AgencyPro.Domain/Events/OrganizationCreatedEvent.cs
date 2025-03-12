using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencyPro.Domain.Events
{
    public class OrganizationCreatedEvent
    {
        public Guid OrganizationId { get; set; }
        public Guid UserId { get; set; }
    }
}
