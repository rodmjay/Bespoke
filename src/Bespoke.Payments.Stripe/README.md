# Bespoke.Payments.Stripe

This package provides Stripe payment processing integration for the Bespoke platform.

## Features

- Stripe API integration
- Customer management
- Card processing
- Subscription management
- Invoice handling
- Refund processing

## Getting Started

```csharp
// Example usage
var stripeCustomerClient = new StripeCustomerClient(apiKey);
var customer = await stripeCustomerClient.CreateCustomer(customerOptions);
```

## Dependencies

- Bespoke.Payments
- Bespoke.Core
- Stripe.net

## License

MIT
