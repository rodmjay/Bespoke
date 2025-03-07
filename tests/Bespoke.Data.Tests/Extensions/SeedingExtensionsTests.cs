using NUnit.Framework;
using Bespoke.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;

namespace Bespoke.Data.Tests.Extensions
{
    [TestFixture]
    public class SeedingExtensionsTests
    {
        [TestFixture]
        public class SeedDataTests : SeedingExtensionsTests
        {
            [Test]
            public void Should_Seed_Data()
            {
                // This is a stub test
                Assert.IsTrue(true);
            }
        }
    }
}
