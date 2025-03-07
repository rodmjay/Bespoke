using NUnit.Framework;
using Bespoke.Payments.Stripe.Builders;
using Bespoke.Payments;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;

namespace Bespoke.Payments.Stripe.Tests.Builders
{
    [TestFixture]
    public class StripePaymentsBuilderTests
    {
        private Mock<PaymentsBuilder> _mockPaymentsBuilder;
        private Mock<IServiceCollection> _mockServices;
        private Mock<IConfiguration> _mockConfiguration;

        [SetUp]
        public void Setup()
        {
            _mockServices = new Mock<IServiceCollection>();
            _mockConfiguration = new Mock<IConfiguration>();
            
            _mockPaymentsBuilder = new Mock<PaymentsBuilder>(null);
            _mockPaymentsBuilder.Setup(x => x.Services).Returns(_mockServices.Object);
            _mockPaymentsBuilder.Setup(x => x.Configuration).Returns(_mockConfiguration.Object);
        }

        [TestFixture]
        public class ConstructorTests : StripePaymentsBuilderTests
        {
            [Test]
            public void Should_Initialize_With_PaymentsBuilder()
            {
                var builder = new StripePaymentsBuilder(_mockPaymentsBuilder.Object);
                Assert.NotNull(builder);
                Assert.IsTrue(true);
            }
        }
    }
}
