using NUnit.Framework;
using Bespoke.Rest.Builders;
using Bespoke.Core.Builders;
using Bespoke.Rest;
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
        private RestSettings _restSettings;

        [SetUp]
        public void Setup()
        {
            _mockServices = new Mock<IServiceCollection>();
            _mockConfiguration = new Mock<IConfiguration>();
            
            _mockAppBuilder = new Mock<AppBuilder>(null);
            _mockAppBuilder.Setup(x => x.Services).Returns(_mockServices.Object);
            _mockAppBuilder.Setup(x => x.Configuration).Returns(_mockConfiguration.Object);
            
            _restSettings = new RestSettings();
        }

        [TestFixture]
        public class ConstructorTests : RestApiBuilderTests
        {
            [Test]
            public void Should_Initialize_With_AppBuilder()
            {
                var builder = new RestApiBuilder(_mockAppBuilder.Object, _restSettings);
                Assert.NotNull(builder);
                Assert.IsTrue(true);
            }
        }
    }
}
