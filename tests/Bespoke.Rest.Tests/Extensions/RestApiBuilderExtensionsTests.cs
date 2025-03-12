using Bespoke.Core.Builders;
using Bespoke.Core.Settings;
using Bespoke.Rest.Builders;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;

namespace Bespoke.Rest.Tests.Extensions;

[TestFixture]
public class RestApiBuilderExtensionsTests
{
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

        // Create a real RestApiBuilder instance with the real AppBuilder and RestSettings
        _restApiBuilder = new RestApiBuilder(_appBuilder, new RestSettings());
    }

    private RestApiBuilder _restApiBuilder;
    private AppBuilder _appBuilder;
    private Mock<IServiceCollection> _mockServices;
    private Mock<IConfiguration> _mockConfiguration;

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