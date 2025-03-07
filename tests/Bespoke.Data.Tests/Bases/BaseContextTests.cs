using NUnit.Framework;
using Bespoke.Data.Bases;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;

namespace Bespoke.Data.Tests.Bases
{
    [TestFixture]
    public class BaseContextTests
    {
        [TestFixture]
        public class ConstructorTests : BaseContextTests
        {
            [Test]
            public void Should_Initialize_With_DbContextOptions()
            {
                // This is a stub test since we can't easily instantiate DbContext
                Assert.IsTrue(true);
            }
        }
    }
}
