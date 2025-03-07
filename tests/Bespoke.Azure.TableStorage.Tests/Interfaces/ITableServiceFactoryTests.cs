using NUnit.Framework;
using Bespoke.Azure.TableStorage.Interfaces;
using Bespoke.Azure.TableStorage.Services;
using Moq;
using Azure.Data.Tables;

namespace Bespoke.Azure.TableStorage.Tests.Interfaces
{
    [TestFixture]
    public class ITableServiceFactoryTests
    {
        private Mock<ITableServiceFactory> _mockTableServiceFactory;
        private Mock<TableService<TestEntity>> _mockTableService;

        [SetUp]
        public void Setup()
        {
            _mockTableService = new Mock<TableService<TestEntity>>();
            _mockTableServiceFactory = new Mock<ITableServiceFactory>();
        }

        [TestFixture]
        public class CreateTableServiceTests : ITableServiceFactoryTests
        {
            [Test]
            public void Should_Call_CreateTableService()
            {
                // Arrange
                string tableName = "testTable";
                
                _mockTableServiceFactory.Setup(x => x.CreateTableService<TestEntity>(tableName))
                    .Returns(_mockTableService.Object);

                // Act
                var result = _mockTableServiceFactory.Object.CreateTableService<TestEntity>(tableName);

                // Assert
                _mockTableServiceFactory.Verify(x => x.CreateTableService<TestEntity>(tableName), Times.Once);
                Assert.NotNull(result);
                Assert.IsTrue(true);
            }
        }

        // Test entity class for testing
        private class TestEntity : ITableEntity
        {
            public string PartitionKey { get; set; } = "partition";
            public string RowKey { get; set; } = "row";
            public DateTimeOffset? Timestamp { get; set; }
            public Azure.ETag ETag { get; set; }
        }
    }
}
