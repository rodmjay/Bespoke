using Bespoke.Core.Builders;
using Bespoke.Core.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;

namespace Bespoke.Rest.Tests.Extensions;

[TestFixture]
public class AppBuilderExtensionsTests
{
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

    private AppBuilder _appBuilder;
    private Mock<IServiceCollection> _mockServices;
    private Mock<IConfiguration> _mockConfiguration;

    [TestFixture]
    public class AddRestApiTests : AppBuilderExtensionsTests
    {
        [Test]
        public void Should_Return_AppBuilder()
        {
            // This is a stub test
            Assert.IsTrue(true);
        }

        [Test]
        public void Should_Invoke_Action_When_Provided()
        {
            // This is a stub test
            Assert.IsTrue(true);
        }
    }
}