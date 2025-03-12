using Bespoke.Rest.Middleware;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;
using NUnit.Framework;

namespace Bespoke.Rest.Tests.Middleware;

[TestFixture]
public class ExceptionMiddlewareTests
{
    [SetUp]
    public void Setup()
    {
        _mockNext = new Mock<RequestDelegate>();
        _mockLoggerFactory = new Mock<ILoggerFactory>();

        // Create a real MvcNewtonsoftJsonOptions instance
        _jsonOptions = new MvcNewtonsoftJsonOptions();

        // Set up the mock to return the real options
        _mockJsonOptions = new Mock<IOptions<MvcNewtonsoftJsonOptions>>();
        _mockJsonOptions.Setup(x => x.Value).Returns(_jsonOptions);
    }

    private Mock<RequestDelegate> _mockNext;
    private Mock<ILoggerFactory> _mockLoggerFactory;
    private Mock<IOptions<MvcNewtonsoftJsonOptions>> _mockJsonOptions;
    private MvcNewtonsoftJsonOptions _jsonOptions;

    [TestFixture]
    public class ConstructorTests : ExceptionMiddlewareTests
    {
        [Test]
        public void Should_Initialize_With_Dependencies()
        {
            var middleware =
                new ExceptionMiddleware(_mockNext.Object, _mockLoggerFactory.Object, _mockJsonOptions.Object);
            Assert.NotNull(middleware);
            Assert.IsTrue(true);
        }
    }

    [TestFixture]
    public class InvokeTests : ExceptionMiddlewareTests
    {
        [Test]
        public void Should_Handle_Exceptions()
        {
            // This is a stub test
            Assert.IsTrue(true);
        }
    }
}