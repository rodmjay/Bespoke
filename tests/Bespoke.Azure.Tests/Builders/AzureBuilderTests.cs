using Bespoke.Azure.Builders;
using Bespoke.Core.Builders;
using Bespoke.Core.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;

namespace Bespoke.Azure.Tests.Builders;

[TestFixture]
public class AzureBuilderTests
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
    }

    private AppBuilder _appBuilder;
    private Mock<IServiceCollection> _mockServices;
    private Mock<IConfiguration> _mockConfiguration;

    [TestFixture]
    public class ConstructorTests : AzureBuilderTests
    {
        [Test]
        public void Should_Initialize_With_AppBuilder()
        {
            var azureBuilder = new AzureBuilder(_appBuilder, new AzureSettings());
            Assert.NotNull(azureBuilder);
            Assert.IsTrue(true);
        }
    }
}