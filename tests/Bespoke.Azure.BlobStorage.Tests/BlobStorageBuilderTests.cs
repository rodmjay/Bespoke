using Bespoke.Azure.Builders;
using Bespoke.Core.Builders;
using Bespoke.Core.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;

namespace Bespoke.Azure.BlobStorage.Tests;

[TestFixture]
public class BlobStorageBuilderTests
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

        // Create a real AzureBuilder instance with the real AppBuilder
        _azureBuilder = new AzureBuilder(_appBuilder, new AzureSettings());
    }

    private AzureBuilder _azureBuilder;
    private AppBuilder _appBuilder;
    private Mock<IServiceCollection> _mockServices;
    private Mock<IConfiguration> _mockConfiguration;

    [TestFixture]
    public class ConstructorTests : BlobStorageBuilderTests
    {
        [Test]
        public void Should_Initialize_With_AzureBuilder()
        {
            var blobStorageBuilder = new BlobStorageBuilder(_azureBuilder);
            Assert.NotNull(blobStorageBuilder);
            Assert.IsTrue(true);
        }
    }
}