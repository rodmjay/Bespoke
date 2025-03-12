using Bespoke.Core.Builders;
using Bespoke.Core.Settings;
using Bespoke.Rest.Builders;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;

namespace Bespoke.Rest.Tests.Builders;

[TestFixture]
public class RestApiBuilderTests
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

        _restSettings = new RestSettings();
    }

    private AppBuilder _appBuilder;
    private Mock<IServiceCollection> _mockServices;
    private Mock<IConfiguration> _mockConfiguration;
    private RestSettings _restSettings;

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