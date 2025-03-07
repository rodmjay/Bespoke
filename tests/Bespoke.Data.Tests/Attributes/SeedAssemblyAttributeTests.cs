using NUnit.Framework;
using Bespoke.Data.Attributes;
using System;

namespace Bespoke.Data.Tests.Attributes
{
    [TestFixture]
    public class SeedAssemblyAttributeTests
    {
        [TestFixture]
        public class ConstructorTests : SeedAssemblyAttributeTests
        {
            [Test]
            public void Should_Initialize_With_Default_Values()
            {
                var attribute = new SeedAssemblyAttribute();
                Assert.NotNull(attribute);
                Assert.IsTrue(true);
            }
        }
    }
}
