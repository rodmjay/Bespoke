using NUnit.Framework;
using Bespoke.Rest.Builders;
using Bespoke.Core.Builders;
using Bespoke.Core.Settings;
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
        private AppBuilder _appBuilder;
        private Mock<IServiceCollection> _mockServices;
        private Mock<IConfiguration> _mockConfiguration;
        private RestSettings _restSettings;

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
            
            _restSettings = new RestSettings();
        }

        [TestFixture]
        public class ConstructorTests : RestApiBuilderTests
        {
            [Test]
            public void Should_Initialize_With_AppBuilder()
            {
                var builder = new RestApiBuilder(_appBuilder, _restSettings);
                Assert.NotNull(builder);
                Assert.IsTrue(true);
            }
        }
    }
}
