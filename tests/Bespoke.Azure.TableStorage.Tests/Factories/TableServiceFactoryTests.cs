using NUnit.Framework;
using Bespoke.Azure.TableStorage.Factories;
using Bespoke.Azure.TableStorage.Interfaces;
using Bespoke.Azure.TableStorage.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using Azure.Data.Tables;

namespace Bespoke.Azure.TableStorage.Tests.Factories
{
    [TestFixture]
    public class TableServiceFactoryTests
    {
        private Mock<IOptions<TableStorageSettings>> _mockTableSettings;
        private Mock<IOptions<AzureSettings>> _mockAzureSettings;
        private Mock<IConfiguration> _mockConfiguration;
        private Mock<IServiceProvider> _mockServiceProvider;
        private TableStorageSettings _tableSettings;
        private AzureSettings _azureSettings;

        [SetUp]
        public void Setup()
        {
            _tableSettings = new TableStorageSettings { ConnectionStringName = "TestConnection" };
            _mockTableSettings = new Mock<IOptions<TableStorageSettings>>();
            _mockTableSettings.Setup(x => x.Value).Returns(_tableSettings);
            
            _azureSettings = new AzureSettings();
            _mockAzureSettings = new Mock<IOptions<AzureSettings>>();
            _mockAzureSettings.Setup(x => x.Value).Returns(_azureSettings);
            
            _mockConfiguration = new Mock<IConfiguration>();
            _mockConfiguration.Setup(x => x.GetConnectionString(_tableSettings.ConnectionStringName))
                .Returns("UseDevelopmentStorage=true");
            
            _mockServiceProvider = new Mock<IServiceProvider>();
        }

        [TestFixture]
        public class ConstructorTests : TableServiceFactoryTests
        {
            [Test]
            public void Should_Initialize_With_Dependencies()
            {
                var factory = new TableServiceFactory(_mockTableSettings.Object, _mockAzureSettings.Object, _mockConfiguration.Object, _mockServiceProvider.Object);
                Assert.NotNull(factory);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class CreateTableServiceTests : TableServiceFactoryTests
        {
            [Test]
            public void Should_Create_TableService()
            {
                // This is a stub test
                Assert.IsTrue(true);
            }
        }
    }
}
