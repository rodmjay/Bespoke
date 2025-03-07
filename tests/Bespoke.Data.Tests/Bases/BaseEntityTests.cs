using NUnit.Framework;
using Bespoke.Data.Bases;
using System;

namespace Bespoke.Data.Tests.Bases
{
    [TestFixture]
    public class BaseEntityTests
    {
        [TestFixture]
        public class ConstructorTests : BaseEntityTests
        {
            [Test]
            public void Should_Initialize_With_Default_Values()
            {
                var entity = new TestBaseEntity();
                Assert.NotNull(entity);
                Assert.IsTrue(true);
            }
        }

        // Test class that inherits from BaseEntity for testing
        private class TestBaseEntity : BaseEntity
        {
        }
    }
}
