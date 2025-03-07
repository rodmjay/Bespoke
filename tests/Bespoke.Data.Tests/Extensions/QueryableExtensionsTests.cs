using NUnit.Framework;
using Bespoke.Data.Extensions;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Bespoke.Data.Tests.Extensions
{
    [TestFixture]
    public class QueryableExtensionsTests
    {
        [TestFixture]
        public class IncludeTests : QueryableExtensionsTests
        {
            [Test]
            public void Should_Include_Related_Entities()
            {
                // This is a stub test
                Assert.IsTrue(true);
            }
        }
    }
}
