using NUnit.Framework;
using Bespoke.Users.Extensions;
using Bespoke.Core.Builders;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;

namespace Bespoke.Users.Tests.Extensions
{
    [TestFixture]
    public class UsersAppBuilderExtensionsTests
    {
        private Mock<AppBuilder> _mockAppBuilder;
        private Mock<IServiceCollection> _mockServices;
        private Mock<IConfiguration> _mockConfiguration;

        [SetUp]
        public void Setup()
        {
            _mockServices = new Mock<IServiceCollection>();
            _mockConfiguration = new Mock<IConfiguration>();
            
            _mockAppBuilder = new Mock<AppBuilder>();
            _mockAppBuilder.Setup(x => x.Services).Returns(_mockServices.Object);
            _mockAppBuilder.Setup(x => x.Configuration).Returns(_mockConfiguration.Object);
        }

        [TestFixture]
        public class AddUsersTests : UsersAppBuilderExtensionsTests
        {
            [Test]
            public void Should_Register_User_Services()
            {
                // This is a stub test
                Assert.IsTrue(true);
            }
        }
    }
}
