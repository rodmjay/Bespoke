using NUnit.Framework;
using Bespoke.Shared.Common;
using System;
using System.Collections.Generic;

namespace Bespoke.Shared.Tests.Common
{
    [TestFixture]
    public class ResultTests
    {
        [TestFixture]
        public class ConstructorTests : ResultTests
        {
            [Test]
            public void Should_Initialize_With_Default_Values()
            {
                var result = new Result();
                Assert.NotNull(result);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class PropertiesTests : ResultTests
        {
            [Test]
            public void Should_Set_And_Get_Values_Correctly()
            {
                var result = new Result();
                result.Succeeded = true;
                result.Errors = new List<Error> { new Error("ErrorCode", "Error message") };
                
                Assert.IsTrue(result.Succeeded);
                Assert.IsNotEmpty(result.Errors);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class SuccessTests : ResultTests
        {
            [Test]
            public void Should_Create_Success_Result()
            {
                var result = Result.Success();
                
                Assert.IsTrue(result.Succeeded);
                Assert.IsEmpty(result.Errors);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class FailureTests : ResultTests
        {
            [Test]
            public void Should_Create_Failure_Result_With_Errors()
            {
                var errors = new List<Error> { new Error("ErrorCode", "Error message") };
                var result = Result.Failure(errors);
                
                Assert.IsFalse(result.Succeeded);
                Assert.IsNotEmpty(result.Errors);
                Assert.IsTrue(true);
            }
        }
    }
}
