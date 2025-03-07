using NUnit.Framework;
using Bespoke.Azure.Queue.Builders;
using Bespoke.Azure.Builders;
using Bespoke.Core.Builders;
using Bespoke.Core.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace Bespoke.Azure.Queue.Tests.Builders
{
    [TestFixture]
    public class QueueStorageBuilderTests
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
        public class ConstructorTests : QueueStorageBuilderTests
        {
            [Test]
            public void Should_Initialize_With_AzureBuilder()
            {
                var queueStorageBuilder = new QueueStorageBuilder(_azureBuilder);
                Assert.NotNull(queueStorageBuilder);
                Assert.IsTrue(true);
            }
        }
    }
}
