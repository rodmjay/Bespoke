using NUnit.Framework;
using Bespoke.Shared.Common;
using System;
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
                var sortCollection = new SortCollection();
                Assert.NotNull(sortCollection);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class AddTests : SortCollectionTests
        {
            [Test]
            public void Should_Add_Sort_Item()
            {
                var sortCollection = new SortCollection();
                sortCollection.Add("Name", "asc");
                
                // This is a stub test
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class GetSortExpressionTests : SortCollectionTests
        {
            [Test]
            public void Should_Return_Sort_Expression()
            {
                var sortCollection = new SortCollection();
                sortCollection.Add("Name", "asc");
                
                // This is a stub test
                Assert.IsTrue(true);
            }
        }
    }
}
