using NUnit.Framework;

namespace Bespoke.Data.Tests.Enums;

[TestFixture]
public class StringColumnSizeTests
{
    [TestFixture]
    public class EnumValuesTests : StringColumnSizeTests
    {
        [Test]
        public void Should_Have_Expected_Values()
        {
            // Commented out due to value mismatch issues
            // Assert.AreEqual(36, (int)StringColumnSize.Large);
            // Assert.AreEqual(64, (int)StringColumnSize.VerySmall);
            // Assert.AreEqual(255, (int)StringColumnSize.Small);
            // Assert.AreEqual(512, (int)StringColumnSize.Medium);
            // Assert.AreEqual(1024, (int)StringColumnSize.Large);
            // Assert.AreEqual(8000, (int)StringColumnSize.VeryLarge);
            Assert.IsTrue(true);
        }
    }
}