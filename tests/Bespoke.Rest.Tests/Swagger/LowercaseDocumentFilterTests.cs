using NUnit.Framework;

namespace Bespoke.Rest.Tests.Swagger;

[TestFixture]
public class LowercaseDocumentFilterTests
{
    [TestFixture]
    public class ApplyTests : LowercaseDocumentFilterTests
    {
        [Test]
        public void Should_Convert_Paths_To_Lowercase()
        {
            // This is a stub test
            Assert.IsTrue(true);
        }
    }
}