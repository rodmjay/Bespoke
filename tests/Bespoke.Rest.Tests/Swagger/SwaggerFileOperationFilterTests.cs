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
    public class SwaggerFileOperationFilterTests
    {
        [TestFixture]
        public class ApplyTests : SwaggerFileOperationFilterTests
        {
            [Test]
            public void Should_Configure_File_Upload_Operations()
            {
                // This is a stub test
                Assert.IsTrue(true);
            }
        }
    }
}
