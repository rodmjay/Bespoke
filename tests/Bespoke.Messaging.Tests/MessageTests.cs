using Bespoke.Messaging.Models;
using NUnit.Framework;

namespace Bespoke.Messaging.Tests
{
    [TestFixture]
    public class MessageTests
    {
        [Test]
        public void Message_WhenCreated_HasDefaultValues()
        {
            // Arrange & Act
            var message = new Message();
            
            // Assert
            Assert.IsNotNull(message);
            Assert.IsEmpty(message.Id);
            Assert.IsEmpty(message.Subject);
            Assert.IsEmpty(message.Body);
            Assert.IsEmpty(message.SenderAddress);
            Assert.IsNotNull(message.RecipientAddresses);
            Assert.IsEmpty(message.RecipientAddresses);
            Assert.IsTrue(message.SentAt <= DateTime.UtcNow);
        }
        
        [Test]
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
            Assert.AreEqual(testId, message.Id);
            Assert.AreEqual(testSubject, message.Subject);
            Assert.AreEqual(testBody, message.Body);
            Assert.AreEqual(testSender, message.SenderAddress);
            Assert.AreEqual(testRecipients, message.RecipientAddresses);
        }
    }
}
