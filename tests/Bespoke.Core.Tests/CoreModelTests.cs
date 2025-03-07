using Bespoke.Core.Models;
using Xunit;

namespace Bespoke.Core.Tests
{
    public class CoreModelTests
    {
        [Fact]
        public void CoreModel_WhenCreated_HasDefaultValues()
        {
            // Arrange & Act
            var model = new CoreModel();
            
            // Assert
            Assert.NotNull(model);
            Assert.NotEmpty(model.Id);
            Assert.True(model.CreatedAt <= DateTime.UtcNow);
        }
        
        [Fact]
        public void CoreModel_WhenIdSet_ReturnsCorrectValue()
        {
            // Arrange
            var model = new CoreModel();
            var testId = "test-id-123";
            
            // Act
            model.Id = testId;
            
            // Assert
            Assert.Equal(testId, model.Id);
        }
    }
}
