using NUnit.Framework;
using Bespoke.Azure.AD.Builders;
using Bespoke.Azure.Builders;
using Moq;

namespace Bespoke.Azure.AD.Tests.Builders
{
    [TestFixture]
    public class AzureAdBuilderTests
    {
        private Mock<AzureBuilder> _mockAzureBuilder;

        [SetUp]
        public void Setup()
        {
            _mockAzureBuilder = new Mock<AzureBuilder>();
        }

        [TestFixture]
        public class ConstructorTests : AzureAdBuilderTests
        {
            [Test]
            public void Should_Initialize_With_AzureBuilder()
            {
                var azureAdBuilder = new AzureAdBuilder(_mockAzureBuilder.Object);
                Assert.NotNull(azureAdBuilder);
                Assert.IsTrue(true);
            }
        }
    }
}
