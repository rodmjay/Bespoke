using NUnit.Framework;
using Bespoke.Azure.Queue.Extensions;
using Bespoke.Azure.Builders;
using Bespoke.Azure.Queue.Builders;
using Moq;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace Bespoke.Azure.Queue.Tests.Extensions
{
    [TestFixture]
    public class QueueStorageExtensionsTests
    {
        private Mock<AzureBuilder> _mockAzureBuilder;
        private Mock<IServiceCollection> _mockServices;

        [SetUp]
        public void Setup()
        {
            _mockServices = new Mock<IServiceCollection>();
            _mockAzureBuilder = new Mock<AzureBuilder>();
            
            // Setup the necessary mocks
            _mockAzureBuilder.Setup(x => x.Services).Returns(_mockServices.Object);
        }

        [TestFixture]
        public class AddQueueStorageTests : QueueStorageExtensionsTests
        {
            [Test]
            public void Should_Return_AzureBuilder()
            {
                var result = QueueStorageExtensions.AddQueueStorage(_mockAzureBuilder.Object);
                Assert.NotNull(result);
                Assert.IsTrue(true);
            }

            [Test]
            public void Should_Invoke_Action_When_Provided()
            {
                bool actionInvoked = false;
                var result = QueueStorageExtensions.AddQueueStorage(_mockAzureBuilder.Object, builder => {
                    actionInvoked = true;
                });
                
                Assert.IsTrue(actionInvoked);
                Assert.NotNull(result);
                Assert.IsTrue(true);
            }
        }
    }
}
