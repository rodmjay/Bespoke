using NUnit.Framework;
using Bespoke.Azure.Queue.Builders;
using Bespoke.Azure.Builders;
using Moq;

namespace Bespoke.Azure.Queue.Tests.Builders
{
    [TestFixture]
    public class QueueStorageBuilderTests
    {
        private Mock<AzureBuilder> _mockAzureBuilder;

        [SetUp]
        public void Setup()
        {
            _mockAzureBuilder = new Mock<AzureBuilder>();
        }

        [TestFixture]
        public class ConstructorTests : QueueStorageBuilderTests
        {
            [Test]
            public void Should_Initialize_With_AzureBuilder()
            {
                var queueStorageBuilder = new QueueStorageBuilder(_mockAzureBuilder.Object);
                Assert.NotNull(queueStorageBuilder);
                Assert.IsTrue(true);
            }
        }
    }
}
