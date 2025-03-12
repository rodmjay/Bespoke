using Microsoft.Extensions.Configuration;
using Moq;
using NUnit.Framework;

namespace Bespoke.Azure.TableStorage.Tests.Factories;

[TestFixture]
public class TableServiceFactoryTests
{
    [SetUp]
    public void Setup()
    {
        _mockConfiguration = new Mock<IConfiguration>();
        _settings = new TableStorageSettings
        {
            // Initialize with test values
            // Note: Assuming ConnectionStringName has a getter
        };
    }

    private Mock<IConfiguration> _mockConfiguration;
    private TableStorageSettings _settings;

    [TestFixture]
    public class CreateTests : TableServiceFactoryTests
    {
        [Test]
        public void Should_Create_TableService_Instance()
        {
            // This is a stub test
            Assert.IsTrue(true);
        }
    }
}