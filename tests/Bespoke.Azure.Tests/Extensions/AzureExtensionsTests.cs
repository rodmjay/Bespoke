using NUnit.Framework;
using Bespoke.Azure.Extensions;
using Bespoke.Core.Builders;
using Moq;
using System;

namespace Bespoke.Azure.Tests.Extensions
{
    [TestFixture]
    public class AzureExtensionsTests
    {
        private Mock<AppBuilder> _mockAppBuilder;

        [SetUp]
        public void Setup()
        {
            _mockAppBuilder = new Mock<AppBuilder>();
        }

        [TestFixture]
        public class AddAzureTests : AzureExtensionsTests
        {
            [Test]
            public void Should_Return_AppBuilder()
            {
                var result = AzureExtensions.AddAzure(_mockAppBuilder.Object);
                Assert.NotNull(result);
                Assert.IsTrue(true);
            }

            [Test]
            public void Should_Invoke_Action_When_Provided()
            {
                bool actionInvoked = false;
                var result = AzureExtensions.AddAzure(_mockAppBuilder.Object, builder => {
                    actionInvoked = true;
                });
                
                Assert.IsTrue(actionInvoked);
                Assert.NotNull(result);
                Assert.IsTrue(true);
            }
        }
    }
}
