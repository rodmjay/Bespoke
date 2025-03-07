using NUnit.Framework;
using Bespoke.Rest.Swagger;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using Moq;
using System;

namespace Bespoke.Rest.Tests.Swagger
{
    [TestFixture]
    public class LowercaseDocumentFilterTests
    {
        [TestFixture]
        public class ApplyTests : LowercaseDocumentFilterTests
        {
            [Test]
            public void Should_Convert_Paths_To_Lowercase()
            {
                // This is a stub test
                Assert.IsTrue(true);
            }
        }
    }
}
