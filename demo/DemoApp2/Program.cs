using Bespoke.Core.Models;
using Bespoke.Messaging.Models;

namespace Bespoke.Demo.DemoApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bespoke DemoApp2");
            
            // Create a sample core model
            var model = new CoreModel
            {
                Id = Guid.NewGuid().ToString()
            };
            
            Console.WriteLine($"Created model with ID: {model.Id} at {model.CreatedAt}");
            
            // Demonstrate messaging
            var message = new Message
            {
                Id = Guid.NewGuid().ToString(),
                Subject = "Test Message",
                Body = "This is a test message from DemoApp2",
                SenderAddress = "sender@example.com",
                RecipientAddresses = new List<string> { "recipient@example.com" }
            };
            
            Console.WriteLine($"Created message: {message.Id}");
            Console.WriteLine($"Subject: {message.Subject}");
            Console.WriteLine($"Sent at: {message.SentAt}");
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
