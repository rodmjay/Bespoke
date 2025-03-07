using NUnit.Framework;
using Bespoke.Azure.Extensions;
using Bespoke.Core.Builders;
using Bespoke.Core.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;

namespace Bespoke.Azure.Tests.Extensions
{
    [TestFixture]
    public class AzureExtensionsTests
    {
        private AppBuilder _appBuilder;
        private Mock<IServiceCollection> _mockServices;
        private Mock<IConfiguration> _mockConfiguration;

        [SetUp]
        public void Setup()
        {
            _mockServices = new Mock<IServiceCollection>();
            _mockConfiguration = new Mock<IConfiguration>();
            
            // Create a real AppBuilder instance with mocked dependencies
            _appBuilder = new AppBuilder(
                _mockServices.Object,
                new AppSettings(),
                _mockConfiguration.Object);
        }

        [TestFixture]
        public class AddAzureTests : AzureExtensionsTests
        {
            [Test]
            public void Should_Return_AppBuilder()
            {
                var result = AzureExtensions.AddAzure(_appBuilder);
                Assert.NotNull(result);
                Assert.IsTrue(true);
            }

            [Test]
            public void Should_Invoke_Action_When_Provided()
            {
                bool actionInvoked = false;
                var result = AzureExtensions.AddAzure(_appBuilder, builder => {
                    actionInvoked = true;
                });
                
                Assert.IsTrue(actionInvoked);
                Assert.NotNull(result);
                Assert.IsTrue(true);
            }
        }
    }
}
