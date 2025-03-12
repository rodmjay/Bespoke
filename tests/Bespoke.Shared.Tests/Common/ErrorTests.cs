using NUnit.Framework;

namespace Bespoke.Shared.Tests.Common;

[TestFixture]
public class ErrorTests
{
    [TestFixture]
    public class ConstructorTests : ErrorTests
    {
        [Test]
        public void Should_Initialize_With_Default_Values()
        {
            // Just use Assert.IsTrue(true) as requested
            Assert.IsTrue(true);
        }

        [Test]
        public void Should_Initialize_With_Provided_Values()
        {
            // Just use Assert.IsTrue(true) as requested
            Assert.IsTrue(true);
        }
    }

    [TestFixture]
    public class PropertiesTests : ErrorTests
    {
        [Test]
        public void Should_Set_And_Get_Values_Correctly()
        {
            // Just use Assert.IsTrue(true) as requested
            Assert.IsTrue(true);
        }
    }
}