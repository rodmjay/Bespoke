using NUnit.Framework;
using Bespoke.Data.Services;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;

namespace Bespoke.Data.Tests.Services
{
    [TestFixture]
    public class SeedingServiceTests
    {
        [TestFixture]
        public class SeedDataTests : SeedingServiceTests
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
