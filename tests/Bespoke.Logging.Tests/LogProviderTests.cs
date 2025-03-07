using Bespoke.Logging.Providers;
using Xunit;

namespace Bespoke.Logging.Tests
{
    public class LogProviderTests
    {
        private class TestLogProvider : LogProvider
        {
            public string LastMessage { get; private set; } = string.Empty;
            public LogLevel LastLevel { get; private set; }
            
            public override void Log(string message, LogLevel level)
            {
                LastMessage = message;
                LastLevel = level;
            }
        }
        
        [Fact]
        public void LogInformation_SetsCorrectLevel()
        {
            // Arrange
            var provider = new TestLogProvider();
            var message = "Test information message";
            
            // Act
            provider.LogInformation(message);
            
            // Assert
            Assert.Equal(message, provider.LastMessage);
            Assert.Equal(LogLevel.Information, provider.LastLevel);
        }
        
        [Fact]
        public void LogWarning_SetsCorrectLevel()
        {
            // Arrange
            var provider = new TestLogProvider();
            var message = "Test warning message";
            
            // Act
            provider.LogWarning(message);
            
            // Assert
            Assert.Equal(message, provider.LastMessage);
            Assert.Equal(LogLevel.Warning, provider.LastLevel);
        }
        
        [Fact]
        public void LogError_SetsCorrectLevel()
        {
            // Arrange
            var provider = new TestLogProvider();
            var message = "Test error message";
            
            // Act
            provider.LogError(message);
            
            // Assert
            Assert.Equal(message, provider.LastMessage);
            Assert.Equal(LogLevel.Error, provider.LastLevel);
        }
    }
}
