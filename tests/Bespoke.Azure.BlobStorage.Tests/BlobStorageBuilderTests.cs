using NUnit.Framework;
using Bespoke.Azure.BlobStorage;
using Bespoke.Azure.Builders;
using Moq;

namespace Bespoke.Azure.BlobStorage.Tests
{
    [TestFixture]
    public class BlobStorageBuilderTests
    {
        private Mock<AzureBuilder> _mockAzureBuilder;

        [SetUp]
        public void Setup()
        {
            _mockAzureBuilder = new Mock<AzureBuilder>();
        }

        [TestFixture]
        public class ConstructorTests : BlobStorageBuilderTests
        {
            [Test]
            public void Should_Initialize_With_AzureBuilder()
            {
                var blobStorageBuilder = new BlobStorageBuilder(_mockAzureBuilder.Object);
                Assert.NotNull(blobStorageBuilder);
                Assert.IsTrue(true);
            }
        }
    }
}
