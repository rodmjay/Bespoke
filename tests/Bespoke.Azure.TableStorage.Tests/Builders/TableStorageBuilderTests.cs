using NUnit.Framework;
using Bespoke.Azure.TableStorage.Builders;
using Bespoke.Azure.Builders;
using Bespoke.Core.Builders;
using Bespoke.Core.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace Bespoke.Azure.TableStorage.Tests.Builders
{
    [TestFixture]
    public class TableStorageBuilderTests
    {
        private AzureBuilder _azureBuilder;
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
                
            // Create a real AzureBuilder instance with the real AppBuilder
            _azureBuilder = new AzureBuilder(_appBuilder);
        }

        [TestFixture]
        public class ConstructorTests : TableStorageBuilderTests
        {
            [Test]
            public void Should_Initialize_With_AzureBuilder()
            {
                var tableStorageBuilder = new TableStorageBuilder(_azureBuilder);
                Assert.NotNull(tableStorageBuilder);
                Assert.IsTrue(true);
            }
        }
    }
}
