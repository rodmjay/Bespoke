using Bespoke.Core.Models;
using NUnit.Framework;

namespace Bespoke.Core.Tests
{
    [TestFixture]
    public class CoreModelTests
    {
        [Test]
        public void CoreModel_WhenCreated_HasDefaultValues()
        {
            // Arrange & Act
            var model = new CoreModel();
            
            // Assert
            Assert.IsNotNull(model);
            Assert.IsNotEmpty(model.Id);
            Assert.IsTrue(model.CreatedAt <= DateTime.UtcNow);
        }
        
        [Test]
        public void CoreModel_WhenIdSet_ReturnsCorrectValue()
        {
            // Arrange
            var model = new CoreModel();
            var testId = "test-id-123";
            
            // Act
            model.Id = testId;
            
            // Assert
            Assert.AreEqual(testId, model.Id);
        }
    }
}
