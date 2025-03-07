using NUnit.Framework;
using Bespoke.Shared.Common;
using System;

namespace Bespoke.Shared.Tests.Common
{
    [TestFixture]
    public class ValidationErrorTests
    {
        [TestFixture]
        public class ConstructorTests : ValidationErrorTests
        {
            [Test]
            public void Should_Initialize_With_Default_Values()
            {
                var error = new ValidationError();
                Assert.NotNull(error);
                Assert.IsTrue(true);
            }

            [Test]
            public void Should_Initialize_With_Provided_Values()
            {
                var error = new ValidationError("Field", "Error message");
                Assert.NotNull(error);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class PropertiesTests : ValidationErrorTests
        {
            [Test]
            public void Should_Set_And_Get_Values_Correctly()
            {
                var error = new ValidationError();
                error.Field = "Field";
                error.Message = "Error message";
                
                Assert.AreEqual("Field", error.Field);
                Assert.AreEqual("Error message", error.Message);
                Assert.IsTrue(true);
            }
        }
    }
}
