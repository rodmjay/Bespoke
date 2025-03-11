using Bespoke.Core.Models;

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
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
