using NUnit.Framework;
using Bespoke.Data.Enums;
using System;

namespace Bespoke.Data.Tests.Enums
{
    [TestFixture]
    public class StringColumnSizeTests
    {
        [TestFixture]
        public class EnumValuesTests : StringColumnSizeTests
        {
            [Test]
            public void Should_Have_Expected_Values()
            {
                Assert.AreEqual(36, (int)StringColumnSize.Guid);
                Assert.AreEqual(50, (int)StringColumnSize.Name);
                Assert.AreEqual(100, (int)StringColumnSize.Title);
                Assert.AreEqual(250, (int)StringColumnSize.Default);
                Assert.AreEqual(500, (int)StringColumnSize.Description);
                Assert.AreEqual(1000, (int)StringColumnSize.Long);
                Assert.AreEqual(2000, (int)StringColumnSize.VeryLong);
                Assert.IsTrue(true);
            }
        }
    }
}
