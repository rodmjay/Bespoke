using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using Bespoke.Core.Builders;
using Bespoke.Core.Settings;
using Bespoke.Tests.Stubs;

namespace Bespoke.Tests.CoreProject.Builders
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
            Assert.That(_appBuilder.Services, "Services should match the initialized collection.", Is.EqualTo(_services));
            Assert.That(_appBuilder.Configuration, "Configuration should match the initialized configuration.", Is.EqualTo(_configuration));
            Assert.That(_appBuilder.AppSettings, "AppSettings should match the initialized settings.", Is.EqualTo(_appSettings));
        }

        [Test]
        public void Build_ShouldReturnValidServiceProvider()
        {
            // Act
            var serviceProvider = _appBuilder.Build();

            // Assert
            Assert.That(serviceProvider, Is.Not.Null, "Service provider should not be null.");
            Assert.That(serviceProvider, Is.InstanceOf<IServiceProvider>, "Service provider should be of type IServiceProvider.");
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
            Assert.That(resolvedService, Is.Not.Null, "Resolved service should not be null.");
            Assert.That(resolvedService, Is.InstanceOf<TestService>, "Resolved service should be of type TestService.");
        }
    }
}
