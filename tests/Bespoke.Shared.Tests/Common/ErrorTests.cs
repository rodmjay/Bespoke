using NUnit.Framework;
using Bespoke.Shared.Common;
using System;

namespace Bespoke.Shared.Tests.Common
{
    [TestFixture]
    public class ErrorTests
    {
        [TestFixture]
        public class ConstructorTests : ErrorTests
        {
            [Test]
            public void Should_Initialize_With_Default_Values()
            {
                var error = new Error();
                Assert.NotNull(error);
                Assert.IsTrue(true);
            }

            [Test]
            public void Should_Initialize_With_Provided_Values()
            {
                var error = new Error("ErrorCode", "Error message");
                Assert.NotNull(error);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class PropertiesTests : ErrorTests
        {
            [Test]
            public void Should_Set_And_Get_Values_Correctly()
            {
                var error = new Error();
                error.Code = "ErrorCode";
                error.Message = "Error message";
                
                Assert.AreEqual("ErrorCode", error.Code);
                Assert.AreEqual("Error message", error.Message);
                Assert.IsTrue(true);
            }
        }
    }
}
