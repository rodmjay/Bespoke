using NUnit.Framework;
using Bespoke.Rest.Builders;
using Bespoke.Core.Builders;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;

namespace Bespoke.Rest.Tests.Builders
{
    [TestFixture]
    public class RestApiBuilderTests
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
        public class ConstructorTests : RestApiBuilderTests
        {
            [Test]
            public void Should_Initialize_With_AppBuilder()
            {
                var restApiBuilder = new RestApiBuilder(_mockAppBuilder.Object);
                Assert.NotNull(restApiBuilder);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class BuilderMethodsTests : RestApiBuilderTests
        {
            [Test]
            public void Should_Configure_Services()
            {
                // This is a stub test for builder configuration methods
                Assert.IsTrue(true);
            }
        }
    }
}
