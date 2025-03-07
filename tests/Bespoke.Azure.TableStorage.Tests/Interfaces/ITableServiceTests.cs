using NUnit.Framework;
using Bespoke.Azure.TableStorage.Interfaces;
using Moq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Azure.Data.Tables;

namespace Bespoke.Azure.TableStorage.Tests.Interfaces
{
    [TestFixture]
    public class ITableServiceTests
    {
        private Mock<ITableService<TestEntity>> _mockTableService;

        [SetUp]
        public void Setup()
        {
            _mockTableService = new Mock<ITableService<TestEntity>>();
        }

        [TestFixture]
        public class InsertEntityAsyncTests : ITableServiceTests
        {
            [Test]
            public async Task Should_Call_InsertEntityAsync()
            {
                // Arrange
                var entity = new TestEntity();
                _mockTableService.Setup(x => x.InsertEntityAsync(entity))
                    .Returns(Task.CompletedTask);

                // Act
                await _mockTableService.Object.InsertEntityAsync(entity);

                // Assert
                _mockTableService.Verify(x => x.InsertEntityAsync(entity), Times.Once);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class RetrieveEntityAsyncTests : ITableServiceTests
        {
            [Test]
            public async Task Should_Call_RetrieveEntityAsync()
            {
                // Arrange
                string partitionKey = "partition";
                string rowKey = "row";
                var expectedEntity = new TestEntity();
                
                _mockTableService.Setup(x => x.RetrieveEntityAsync(partitionKey, rowKey))
                    .ReturnsAsync(expectedEntity);

                // Act
                var result = await _mockTableService.Object.RetrieveEntityAsync(partitionKey, rowKey);

                // Assert
                _mockTableService.Verify(x => x.RetrieveEntityAsync(partitionKey, rowKey), Times.Once);
                Assert.AreEqual(expectedEntity, result);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class UpdateEntityAsyncTests : ITableServiceTests
        {
            [Test]
            public async Task Should_Call_UpdateEntityAsync()
            {
                // Arrange
                var entity = new TestEntity();
                _mockTableService.Setup(x => x.UpdateEntityAsync(entity))
                    .Returns(Task.CompletedTask);

                // Act
                await _mockTableService.Object.UpdateEntityAsync(entity);

                // Assert
                _mockTableService.Verify(x => x.UpdateEntityAsync(entity), Times.Once);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class DeleteEntityAsyncTests : ITableServiceTests
        {
            [Test]
            public async Task Should_Call_DeleteEntityAsync()
            {
                // Arrange
                string partitionKey = "partition";
                string rowKey = "row";
                
                _mockTableService.Setup(x => x.DeleteEntityAsync(partitionKey, rowKey))
                    .Returns(Task.CompletedTask);

                // Act
                await _mockTableService.Object.DeleteEntityAsync(partitionKey, rowKey);

                // Assert
                _mockTableService.Verify(x => x.DeleteEntityAsync(partitionKey, rowKey), Times.Once);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class QueryEntitiesAsyncTests : ITableServiceTests
        {
            [Test]
            public async Task Should_Call_QueryEntitiesAsync()
            {
                // Arrange
                string filter = "PartitionKey eq 'partition'";
                var expectedEntities = new List<TestEntity> { new TestEntity() };
                
                _mockTableService.Setup(x => x.QueryEntitiesAsync(filter))
                    .ReturnsAsync(expectedEntities);

                // Act
                var result = await _mockTableService.Object.QueryEntitiesAsync(filter);

                // Assert
                _mockTableService.Verify(x => x.QueryEntitiesAsync(filter), Times.Once);
                Assert.AreEqual(expectedEntities, result);
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
