using NUnit.Framework;
using Bespoke.Payments;
using Bespoke.Core.Builders;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;

namespace Bespoke.Payments.Tests
{
    [TestFixture]
    public class PaymentsBuilderTests
    {
        private Mock<AppBuilder> _mockAppBuilder;
        private Mock<IServiceCollection> _mockServices;
        private Mock<IConfiguration> _mockConfiguration;

        [SetUp]
        public void Setup()
        {
            _mockServices = new Mock<IServiceCollection>();
            _mockConfiguration = new Mock<IConfiguration>();
            
            _mockAppBuilder = new Mock<AppBuilder>();
            _mockAppBuilder.Setup(x => x.Services).Returns(_mockServices.Object);
            _mockAppBuilder.Setup(x => x.Configuration).Returns(_mockConfiguration.Object);
        }

        [TestFixture]
        public class ConstructorTests : PaymentsBuilderTests
        {
            [Test]
            public void Should_Initialize_With_AppBuilder()
            {
                var paymentsBuilder = new PaymentsBuilder(_mockAppBuilder.Object);
                Assert.NotNull(paymentsBuilder);
                Assert.IsTrue(true);
            }
        }
    }
}
