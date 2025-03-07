using NUnit.Framework;
using Bespoke.Rest.Extensions;
using Bespoke.Rest.Builders;
using Bespoke.Core.Builders;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;

namespace Bespoke.Rest.Tests.Extensions
{
    [TestFixture]
    public class RestApiBuilderExtensionsTests
    {
        private Mock<RestApiBuilder> _mockRestApiBuilder;
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
            
            _mockRestApiBuilder = new Mock<RestApiBuilder>(_mockAppBuilder.Object);
        }

        [TestFixture]
        public class ExtensionMethodsTests : RestApiBuilderExtensionsTests
        {
            [Test]
            public void Should_Configure_Services()
            {
                // This is a stub test for extension methods
                Assert.IsTrue(true);
            }
        }
    }
}
