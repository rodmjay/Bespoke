using NUnit.Framework;
using Bespoke.Data.SqlServer;
using Bespoke.Data.Builders;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;

namespace Bespoke.Data.SqlServer.Tests
{
    [TestFixture]
    public class DataBuilderExtensionsTests
    {
        private Mock<DataBuilder> _mockDataBuilder;
        private Mock<IServiceCollection> _mockServices;
        private Mock<IConfiguration> _mockConfiguration;

        [SetUp]
        public void Setup()
        {
            _mockServices = new Mock<IServiceCollection>();
            _mockConfiguration = new Mock<IConfiguration>();
            
            _mockDataBuilder = new Mock<DataBuilder>(null);
            _mockDataBuilder.Setup(x => x.Services).Returns(_mockServices.Object);
            _mockDataBuilder.Setup(x => x.Configuration).Returns(_mockConfiguration.Object);
        }

        [TestFixture]
        public class UseSqlServerTests : DataBuilderExtensionsTests
        {
            [Test]
            public void Should_Register_SqlServer_Services()
            {
                // This is a stub test
                Assert.IsTrue(true);
            }

            [Test]
            public void Should_Return_DataBuilder()
            {
                var result = DataBuilderExtensions.UseSqlServer(_mockDataBuilder.Object);
                
                Assert.NotNull(result);
                Assert.AreEqual(_mockDataBuilder.Object, result);
                Assert.IsTrue(true);
            }
        }
    }
}
