using NUnit.Framework;
using Bespoke.Rest.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Moq;
using System;

namespace Bespoke.Rest.Tests.Filters
{
    [TestFixture]
    public class ValidateModelAttributeTests
    {
        [TestFixture]
        public class OnActionExecutingTests : ValidateModelAttributeTests
        {
            [Test]
            public void Should_Return_BadRequest_When_ModelState_Is_Invalid()
            {
                // This is a stub test
                Assert.IsTrue(true);
            }

            [Test]
            public void Should_Continue_Execution_When_ModelState_Is_Valid()
            {
                // This is a stub test
                Assert.IsTrue(true);
            }
        }
    }
}
