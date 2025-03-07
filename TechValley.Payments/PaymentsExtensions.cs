using TechValley.Core.Builders;

namespace TechValley.Payments
{
    public static class PaymentsExtensions
    {
       public static AppBuilder AddPayments(this AppBuilder builder, Action<PaymentsBuilder>? build= default)
        {
            var paymentsBuilder = new PaymentsBuilder(builder);
            
            build?.Invoke(paymentsBuilder);

            return builder;
        }

    }
}
