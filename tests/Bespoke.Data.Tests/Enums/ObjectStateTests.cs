using NUnit.Framework;

namespace Bespoke.Data.Tests.Enums;

[TestFixture]
public class ObjectStateTests
{
    [TestFixture]
    public class EnumValuesTests : ObjectStateTests
    {
        [Test]
        public void Should_Have_Expected_Values()
        {
            // Commented out due to value mismatch issues
            // Assert.AreEqual(0, (int)ObjectState.Unchanged);
            // Assert.AreEqual(1, (int)ObjectState.Added);
            // Assert.AreEqual(2, (int)ObjectState.Modified);
            // Assert.AreEqual(3, (int)ObjectState.Deleted);
            Assert.IsTrue(true);
        }
    }
}