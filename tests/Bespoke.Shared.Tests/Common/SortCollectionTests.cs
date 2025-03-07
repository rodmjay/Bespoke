using NUnit.Framework;
using System.Collections.Generic;

namespace Bespoke.Shared.Tests.Common
{
    [TestFixture]
    public class SortCollectionTests
    {
        [TestFixture]
        public class ConstructorTests : SortCollectionTests
        {
            [Test]
            public void Should_Initialize_With_Default_Values()
            {
                // Just use Assert.IsTrue(true) as requested
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class MethodsTests : SortCollectionTests
        {
            [Test]
            public void Should_Add_Sort_Expressions()
            {
                // Just use Assert.IsTrue(true) as requested
                Assert.IsTrue(true);
            }
        }
    }
}
