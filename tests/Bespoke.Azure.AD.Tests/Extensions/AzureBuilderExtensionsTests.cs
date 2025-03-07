using NUnit.Framework;
using Bespoke.Azure.AD.Extensions;
using Bespoke.Azure.Builders;
using Moq;
using System;

namespace Bespoke.Azure.AD.Tests.Extensions
{
    [TestFixture]
    public class AzureBuilderExtensionsTests
    {
        private Mock<AzureBuilder> _mockAzureBuilder;

        [SetUp]
        public void Setup()
        {
            _mockAzureBuilder = new Mock<AzureBuilder>();
        }

        [TestFixture]
        public class AddAzureAdTests : AzureBuilderExtensionsTests
        {
            [Test]
            public void Should_Return_AzureBuilder()
            {
                var result = AzureBuilderExtensions.AddAzureAd(_mockAzureBuilder.Object);
                Assert.NotNull(result);
                Assert.IsTrue(true);
            }

            [Test]
            public void Should_Invoke_Action_When_Provided()
            {
                bool actionInvoked = false;
                var result = AzureBuilderExtensions.AddAzureAd(_mockAzureBuilder.Object, builder => {
                    actionInvoked = true;
                });
                
                Assert.IsTrue(actionInvoked);
                Assert.NotNull(result);
                Assert.IsTrue(true);
            }
        }
    }
}
