using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bespoke.Payments.Stripe
{
    public class StripeSettings
    {
        public string? ApiKey { get; set; }
        public bool UseWebHooks { get; set; }
        public bool UseStripeConnect { get; set; }
    }
}
