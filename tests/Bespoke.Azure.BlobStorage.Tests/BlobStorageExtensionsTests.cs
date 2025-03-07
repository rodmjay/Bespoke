using NUnit.Framework;
using Bespoke.Azure.BlobStorage;
using Bespoke.Azure.Builders;
using Moq;
using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace Bespoke.Azure.BlobStorage.Tests
{
    [TestFixture]
    public class BlobStorageExtensionsTests
    {
        private Mock<AzureBuilder> _mockAzureBuilder;
        private Mock<IServiceCollection> _mockServices;
        private Mock<IConfiguration> _mockConfiguration;

        [SetUp]
        public void Setup()
        {
            _mockServices = new Mock<IServiceCollection>();
            _mockConfiguration = new Mock<IConfiguration>();
            _mockAzureBuilder = new Mock<AzureBuilder>();
            
            // Setup the necessary mocks
            _mockAzureBuilder.Setup(x => x.Services).Returns(_mockServices.Object);
            _mockAzureBuilder.Setup(x => x.Configuration).Returns(_mockConfiguration.Object);
        }

        [TestFixture]
        public class AddBlobStorageTests : BlobStorageExtensionsTests
        {
            [Test]
            public void Should_Return_AzureBuilder()
            {
                var result = BlobStorageExtensions.AddBlobStorage(_mockAzureBuilder.Object);
                Assert.NotNull(result);
                Assert.IsTrue(true);
            }

            [Test]
            public void Should_Invoke_Action_When_Provided()
            {
                bool actionInvoked = false;
                var result = BlobStorageExtensions.AddBlobStorage(_mockAzureBuilder.Object, builder => {
                    actionInvoked = true;
                });
                
                Assert.IsTrue(actionInvoked);
                Assert.NotNull(result);
                Assert.IsTrue(true);
            }
        }
    }
}
