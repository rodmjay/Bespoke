using Bespoke.Core.Models;
using Bespoke.Logging.Providers;

namespace Bespoke.Demo.DemoApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bespoke DemoApp1");
            
            // Create a sample core model
            var model = new CoreModel
            {
                Id = Guid.NewGuid().ToString()
            };
            
            Console.WriteLine($"Created model with ID: {model.Id} at {model.CreatedAt}");
            
            // Demonstrate logging
            var logger = new ConsoleLogProvider();
            logger.LogInformation("Application started");
            logger.LogInformation($"Created model: {model.Id}");
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
    
    // Simple console log provider implementation for demo purposes
    public class ConsoleLogProvider : LogProvider
    {
        public override void Log(string message, LogLevel level)
        {
            Console.WriteLine($"[{level}] {DateTime.UtcNow}: {message}");
        }
    }
}
