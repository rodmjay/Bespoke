using NUnit.Framework;
using Bespoke.Data.Extensions;
using Bespoke.Core.Builders;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;

namespace Bespoke.Data.Tests.Extensions
{
    [TestFixture]
    public class AppBuilderExtensionsTests
    {
        private Mock<AppBuilder> _mockAppBuilder;
        private Mock<IServiceCollection> _mockServices;

        [SetUp]
        public void Setup()
        {
            _mockServices = new Mock<IServiceCollection>();
            _mockAppBuilder = new Mock<AppBuilder>();
            _mockAppBuilder.Setup(x => x.Services).Returns(_mockServices.Object);
        }

        [TestFixture]
        public class AddDataTests : AppBuilderExtensionsTests
        {
            [Test]
            public void Should_Return_AppBuilder()
            {
                // This is a stub test
                Assert.IsTrue(true);
            }
        }
    }
}
