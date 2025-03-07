using NUnit.Framework;
using Bespoke.Azure.TableStorage.Builders;
using Bespoke.Azure.Builders;
using Moq;

namespace Bespoke.Azure.TableStorage.Tests.Builders
{
    [TestFixture]
    public class TableStorageBuilderTests
    {
        private Mock<AzureBuilder> _mockAzureBuilder;

        [SetUp]
        public void Setup()
        {
            _mockAzureBuilder = new Mock<AzureBuilder>();
        }

        [TestFixture]
        public class ConstructorTests : TableStorageBuilderTests
        {
            [Test]
            public void Should_Initialize_With_AzureBuilder()
            {
                var tableStorageBuilder = new TableStorageBuilder(_mockAzureBuilder.Object);
                Assert.NotNull(tableStorageBuilder);
                Assert.IsTrue(true);
            }
        }
    }
}
