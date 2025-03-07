namespace Bespoke.Logging.Providers
{
    /// <summary>
    /// Base log provider for the Logging library
    /// </summary>
    public abstract class LogProvider
    {
        public abstract void Log(string message, LogLevel level);
        
        public void LogInformation(string message)
        {
            Log(message, LogLevel.Information);
        }
        
        public void LogWarning(string message)
        {
            Log(message, LogLevel.Warning);
        }
        
        public void LogError(string message)
        {
            Log(message, LogLevel.Error);
        }
    }
    
    public enum LogLevel
    {
        Information,
        Warning,
        Error
    }
}
