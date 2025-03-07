using NUnit.Framework;
using Bespoke.Azure.Queue.Interfaces;
using Moq;
using System.Threading.Tasks;

namespace Bespoke.Azure.Queue.Tests.Interfaces
{
    [TestFixture]
    public class IQueueServiceTests
    {
        private Mock<IQueueService> _mockQueueService;

        [SetUp]
        public void Setup()
        {
            _mockQueueService = new Mock<IQueueService>();
        }

        [TestFixture]
        public class CreateIfNotExistsAsyncTests : IQueueServiceTests
        {
            [Test]
            public async Task Should_Call_CreateIfNotExistsAsync()
            {
                // Arrange
                _mockQueueService.Setup(x => x.CreateIfNotExistsAsync())
                    .Returns(Task.CompletedTask);

                // Act
                await _mockQueueService.Object.CreateIfNotExistsAsync();

                // Assert
                _mockQueueService.Verify(x => x.CreateIfNotExistsAsync(), Times.Once);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class AddMessageAsyncTests : IQueueServiceTests
        {
            [Test]
            public async Task Should_Call_AddMessageAsync()
            {
                // Arrange
                string message = "Test message";
                _mockQueueService.Setup(x => x.AddMessageAsync(message))
                    .Returns(Task.CompletedTask);

                // Act
                await _mockQueueService.Object.AddMessageAsync(message);

                // Assert
                _mockQueueService.Verify(x => x.AddMessageAsync(message), Times.Once);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class PeekMessageAsyncTests : IQueueServiceTests
        {
            [Test]
            public async Task Should_Call_PeekMessageAsync()
            {
                // Arrange
                _mockQueueService.Setup(x => x.PeekMessageAsync())
                    .Returns(Task.CompletedTask);

                // Act
                await _mockQueueService.Object.PeekMessageAsync();

                // Assert
                _mockQueueService.Verify(x => x.PeekMessageAsync(), Times.Once);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class GetMessageAsyncTests : IQueueServiceTests
        {
            [Test]
            public async Task Should_Call_GetMessageAsync()
            {
                // Arrange
                _mockQueueService.Setup(x => x.GetMessageAsync())
                    .Returns(Task.CompletedTask);

                // Act
                await _mockQueueService.Object.GetMessageAsync();

                // Assert
                _mockQueueService.Verify(x => x.GetMessageAsync(), Times.Once);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class UpdateMessageAsyncTests : IQueueServiceTests
        {
            [Test]
            public async Task Should_Call_UpdateMessageAsync()
            {
                // Arrange
                string oldMessage = "Old message";
                string newMessage = "New message";
                _mockQueueService.Setup(x => x.UpdateMessageAsync(oldMessage, newMessage))
                    .Returns(Task.CompletedTask);

                // Act
                await _mockQueueService.Object.UpdateMessageAsync(oldMessage, newMessage);

                // Assert
                _mockQueueService.Verify(x => x.UpdateMessageAsync(oldMessage, newMessage), Times.Once);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class DeleteMessageAsyncTests : IQueueServiceTests
        {
            [Test]
            public async Task Should_Call_DeleteMessageAsync()
            {
                // Arrange
                string messageId = "messageId";
                string popReceipt = "popReceipt";
                _mockQueueService.Setup(x => x.DeleteMessageAsync(messageId, popReceipt))
                    .Returns(Task.CompletedTask);

                // Act
                await _mockQueueService.Object.DeleteMessageAsync(messageId, popReceipt);

                // Assert
                _mockQueueService.Verify(x => x.DeleteMessageAsync(messageId, popReceipt), Times.Once);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class ClearQueueAsyncTests : IQueueServiceTests
        {
            [Test]
            public async Task Should_Call_ClearQueueAsync()
            {
                // Arrange
                _mockQueueService.Setup(x => x.ClearQueueAsync())
                    .Returns(Task.CompletedTask);

                // Act
                await _mockQueueService.Object.ClearQueueAsync();

                // Assert
                _mockQueueService.Verify(x => x.ClearQueueAsync(), Times.Once);
                Assert.IsTrue(true);
            }
        }
    }
}
