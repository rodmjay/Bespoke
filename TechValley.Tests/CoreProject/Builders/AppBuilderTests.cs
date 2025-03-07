using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using TechValley.Core.Builders;
using TechValley.Core.Settings;
using TechValley.Tests.Stubs;

namespace TechValley.Tests.CoreProject.Builders
{
    [TestFixture]
    public class AppBuilderTests
    {
        private IServiceCollection _services;
        private AppSettings _appSettings;
        private IConfiguration _configuration;
        private AppBuilder _appBuilder;

        [SetUp]
        public void Setup()
        {
            // Initialize mock dependencies
            _services = new ServiceCollection();
            _appSettings = new AppSettings { Name = "TestApp" };
            var configBuilder = new ConfigurationBuilder();
            configBuilder.AddInMemoryCollection(new Dictionary<string, string>
            {
                { "Key1", "Value1" },
                { "Key2", "Value2" }
            });
            _configuration = configBuilder.Build();

            // Initialize AppBuilder
            _appBuilder = new AppBuilder(_services, _appSettings, _configuration);
        }

        [Test]
        public void Constructor_ShouldInitializeProperties()
        {
            // Assert
            ClassicAssert.AreEqual(_services, _appBuilder.Services, "Services should match the initialized collection.");
            ClassicAssert.AreEqual(_configuration, _appBuilder.Configuration, "Configuration should match the initialized configuration.");
            ClassicAssert.AreEqual(_appSettings, _appBuilder.AppSettings, "AppSettings should match the initialized settings.");
        }

        [Test]
        public void Build_ShouldReturnValidServiceProvider()
        {
            // Act
            var serviceProvider = _appBuilder.Build();

            // Assert
            ClassicAssert.IsNotNull(serviceProvider, "Service provider should not be null.");
            ClassicAssert.IsInstanceOf<IServiceProvider>(serviceProvider, "Service provider should be of type IServiceProvider.");
        }

        [Test]
        public void Build_ShouldResolveRegisteredServices()
        {
            // Arrange
            _services.AddSingleton<ITestService, TestService>();

            // Act
            var serviceProvider = _appBuilder.Build();
            var resolvedService = serviceProvider.GetService<ITestService>();

            // Assert
            ClassicAssert.IsNotNull(resolvedService, "Resolved service should not be null.");
            ClassicAssert.IsInstanceOf<TestService>(resolvedService, "Resolved service should be of type TestService.");
        }
    }
}
