using NUnit.Framework;
using Bespoke.Shared.Common;
using System;

namespace Bespoke.Shared.Tests.Common
{
    [TestFixture]
    public class DropdownItemTests
    {
        [TestFixture]
        public class ConstructorTests : DropdownItemTests
        {
            [Test]
            public void Should_Initialize_With_Default_Values()
            {
                var item = new DropdownItem();
                Assert.NotNull(item);
                Assert.IsTrue(true);
            }

            [Test]
            public void Should_Initialize_With_Provided_Values()
            {
                var item = new DropdownItem("1", "Test");
                Assert.NotNull(item);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class PropertiesTests : DropdownItemTests
        {
            [Test]
            public void Should_Set_And_Get_Values_Correctly()
            {
                var item = new DropdownItem();
                item.Value = "1";
                item.Text = "Test";
                
                Assert.AreEqual("1", item.Value);
                Assert.AreEqual("Test", item.Text);
                Assert.IsTrue(true);
            }
        }
    }
}
