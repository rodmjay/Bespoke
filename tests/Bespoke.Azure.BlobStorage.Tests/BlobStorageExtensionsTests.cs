using NUnit.Framework;
using Bespoke.Azure.BlobStorage;
using Bespoke.Azure.Builders;
using Bespoke.Core.Builders;
using Bespoke.Core.Settings;
using Moq;
using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace Bespoke.Azure.BlobStorage.Tests
{
    [TestFixture]
    public class BlobStorageExtensionsTests
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
        public class AddBlobStorageTests : BlobStorageExtensionsTests
        {
            [Test]
            public void Should_Return_AzureBuilder()
            {
                var result = BlobStorageExtensions.AddBlobStorage(_azureBuilder);
                Assert.NotNull(result);
                Assert.IsTrue(true);
            }

            [Test]
            public void Should_Invoke_Action_When_Provided()
            {
                bool actionInvoked = false;
                var result = BlobStorageExtensions.AddBlobStorage(_azureBuilder, builder => {
                    actionInvoked = true;
                });
                
                Assert.IsTrue(actionInvoked);
                Assert.NotNull(result);
                Assert.IsTrue(true);
            }
        }
    }
}
