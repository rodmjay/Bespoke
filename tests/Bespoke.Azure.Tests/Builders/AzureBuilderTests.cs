using NUnit.Framework;
using Bespoke.Azure.Builders;
using Bespoke.Core.Builders;
using Moq;

namespace Bespoke.Azure.Tests.Builders
{
    [TestFixture]
    public class AzureBuilderTests
    {
        private Mock<AppBuilder> _mockAppBuilder;

        [SetUp]
        public void Setup()
        {
            _mockAppBuilder = new Mock<AppBuilder>();
        }

        [TestFixture]
        public class ConstructorTests : AzureBuilderTests
        {
            [Test]
            public void Should_Initialize_With_AppBuilder()
            {
                var azureBuilder = new AzureBuilder(_mockAppBuilder.Object);
                Assert.NotNull(azureBuilder);
                Assert.IsTrue(true);
            }
        }
    }
}
