using NUnit.Framework;
using Bespoke.Shared.Common;
using System;

namespace Bespoke.Shared.Tests.Common
{
    [TestFixture]
    public class PagingQueryTests
    {
        [TestFixture]
        public class ConstructorTests : PagingQueryTests
        {
            [Test]
            public void Should_Initialize_With_Default_Values()
            {
                var query = new PagingQuery();
                Assert.NotNull(query);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class PropertiesTests : PagingQueryTests
        {
            [Test]
            public void Should_Set_And_Get_Values_Correctly()
            {
                var query = new PagingQuery();
                query.Page = 2;
                query.PageSize = 10;
                query.SortBy = "Name";
                query.SortDirection = "asc";
                
                Assert.AreEqual(2, query.Page);
                Assert.AreEqual(10, query.PageSize);
                Assert.AreEqual("Name", query.SortBy);
                Assert.AreEqual("asc", query.SortDirection);
                Assert.IsTrue(true);
            }
        }
    }
}
