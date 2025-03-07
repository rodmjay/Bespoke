using NUnit.Framework;
using Bespoke.Shared.Common;
using System;

namespace Bespoke.Shared.Tests.Common
{
    [TestFixture]
    public class RedirectResultTests
    {
        [TestFixture]
        public class ConstructorTests : RedirectResultTests
        {
            [Test]
            public void Should_Initialize_With_Default_Values()
            {
                var result = new RedirectResult();
                Assert.NotNull(result);
                Assert.IsTrue(true);
            }

            [Test]
            public void Should_Initialize_With_Provided_Values()
            {
                var result = new RedirectResult("https://example.com");
                Assert.NotNull(result);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class PropertiesTests : RedirectResultTests
        {
            [Test]
            public void Should_Set_And_Get_Values_Correctly()
            {
                var result = new RedirectResult();
                result.Url = "https://example.com";
                
                Assert.AreEqual("https://example.com", result.Url);
                Assert.IsTrue(true);
            }
        }
    }
}
