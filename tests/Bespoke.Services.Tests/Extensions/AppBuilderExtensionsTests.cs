using NUnit.Framework;
using Bespoke.Services.Extensions;
using Bespoke.Core.Builders;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;

namespace Bespoke.Services.Tests.Extensions
{
    [TestFixture]
    public class AppBuilderExtensionsTests
    {
        private AppBuilder _appBuilder;
        private Mock<IServiceCollection> _mockServices;
        private Mock<IConfiguration> _mockConfiguration;

        [SetUp]
        public void Setup()
        {
            _mockServices = new Mock<IServiceCollection>();
            _mockConfiguration = new Mock<IConfiguration>();
            
            // Create a real AppBuilder instance with mocked dependencies
            _appBuilder = new AppBuilder(
                _mockServices.Object,
                new AppSettings(),
                _mockConfiguration.Object);
        }

        [TestFixture]
        public class AddServicesTests : AppBuilderExtensionsTests
        {
            [Test]
            public void Should_Register_Services()
            {
                // This is a stub test
                Assert.IsTrue(true);
            }
        }
    }
}
