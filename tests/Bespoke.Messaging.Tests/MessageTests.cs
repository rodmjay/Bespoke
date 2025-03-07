using Bespoke.Messaging.Models;
using Xunit;

namespace Bespoke.Messaging.Tests
{
    public class MessageTests
    {
        [Fact]
        public void Message_WhenCreated_HasDefaultValues()
        {
            // Arrange & Act
            var message = new Message();
            
            // Assert
            Assert.NotNull(message);
            Assert.Empty(message.Id);
            Assert.Empty(message.Subject);
            Assert.Empty(message.Body);
            Assert.Empty(message.SenderAddress);
            Assert.NotNull(message.RecipientAddresses);
            Assert.Empty(message.RecipientAddresses);
            Assert.True(message.SentAt <= DateTime.UtcNow);
        }
        
        [Fact]
        public void Message_WhenPropertiesSet_ReturnsCorrectValues()
        {
            // Arrange
            var message = new Message();
            var testId = "msg-123";
            var testSubject = "Test Subject";
            var testBody = "Test Body";
            var testSender = "sender@example.com";
            var testRecipients = new List<string> { "recipient1@example.com", "recipient2@example.com" };
            
            // Act
            message.Id = testId;
            message.Subject = testSubject;
            message.Body = testBody;
            message.SenderAddress = testSender;
            message.RecipientAddresses = testRecipients;
            
            // Assert
            Assert.Equal(testId, message.Id);
            Assert.Equal(testSubject, message.Subject);
            Assert.Equal(testBody, message.Body);
            Assert.Equal(testSender, message.SenderAddress);
            Assert.Equal(testRecipients, message.RecipientAddresses);
        }
    }
}
