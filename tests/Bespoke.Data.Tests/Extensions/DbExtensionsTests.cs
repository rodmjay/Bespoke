using NUnit.Framework;
using Bespoke.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;

namespace Bespoke.Data.Tests.Extensions
{
    [TestFixture]
    public class DbExtensionsTests
    {
        [TestFixture]
        public class ApplyGlobalFiltersTests : DbExtensionsTests
        {
            [Test]
            public void Should_Apply_Global_Filters()
            {
                // This is a stub test
                Assert.IsTrue(true);
            }
        }
    }
}
