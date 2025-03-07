using Microsoft.Extensions.Options;
using Stripe;
using System.Collections.Concurrent;
using Bespoke.Payments.Stripe.Interfaces;
using Bespoke.Payments.Stripe.Services;

namespace Bespoke.Payments.Stripe.Factories
{
    public class StripeFactory : IStripeFactory
    {
        private readonly ConcurrentDictionary<string, StripeCustomerClient> _customerServiceCache;

        private readonly IOptions<StripeSettings> _settings;
        public StripeFactory(IOptions<StripeSettings> settings)
        {
            _settings = settings;
            _customerServiceCache = new ConcurrentDictionary<string, StripeCustomerClient>();
        }
        
        public IStripeCustomerClient GetCustomerClient(string customerId)
        {
            if (!_customerServiceCache.ContainsKey(customerId))
            {
                var customerService = new StripeCustomerClient(customerId);
                _customerServiceCache[customerId] = customerService;
            }
            return _customerServiceCache[customerId];
        }

        public IStripeChargeClient GetChargeClient(string chargeId)
        {
            return new StripeChargeClient(chargeId);
        }

        public IStripeCardClient GetCardClient(string cardId)
        {
            return new StripeCardClient(cardId);
        }

        public IStripeSubscriptionClient GetSubscriptionClient(string subscriptionId)
        {
            throw new NotImplementedException();
        }

        public async Task<Customer> CreateCustomerAsync(string email, string name)
        {
            var customerService = new CustomerService();
            var customer = await customerService.CreateAsync(new CustomerCreateOptions
            {
                Email = email,
                Name = name,
            });

            return customer;
        }
    }
}
