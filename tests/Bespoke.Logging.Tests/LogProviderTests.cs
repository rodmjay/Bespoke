using Bespoke.Logging.Providers;
using NUnit.Framework;

namespace Bespoke.Logging.Tests
{
    [TestFixture]
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
        
        [Test]
        public void LogInformation_SetsCorrectLevel()
        {
            // Arrange
            var provider = new TestLogProvider();
            var message = "Test information message";
            
            // Act
            provider.LogInformation(message);
            
            // Assert
            Assert.That(provider.LastMessage, Is.EqualTo(message));
            Assert.That(provider.LastLevel, Is.EqualTo(LogLevel.Information));
        }
        
        [Test]
        public void LogWarning_SetsCorrectLevel()
        {
            // Arrange
            var provider = new TestLogProvider();
            var message = "Test warning message";
            
            // Act
            provider.LogWarning(message);
            
            // Assert
            Assert.That(provider.LastMessage, Is.EqualTo(message));
            Assert.That(provider.LastLevel, Is.EqualTo(LogLevel.Warning));
        }
        
        [Test]
        public void LogError_SetsCorrectLevel()
        {
            // Arrange
            var provider = new TestLogProvider();
            var message = "Test error message";
            
            // Act
            provider.LogError(message);
            
            // Assert
            Assert.That(provider.LastMessage, Is.EqualTo(message));
            Assert.That(provider.LastLevel, Is.EqualTo(LogLevel.Error));
        }
    }
}
