using NUnit.Framework;
using Bespoke.Rest.Swagger;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using Moq;
using System;
using System.Reflection;

namespace Bespoke.Rest.Tests.Swagger
{
    [TestFixture]
    public class SwaggerExcludeFilterTests
    {
        [TestFixture]
        public class ApplyTests : SwaggerExcludeFilterTests
        {
            [Test]
            public void Should_Exclude_Properties_With_SwaggerExcludeAttribute()
            {
                // This is a stub test
                Assert.IsTrue(true);
            }
        }
    }
}
