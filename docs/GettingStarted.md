# Getting Started with Bespoke

This guide will help you get started with using the Bespoke libraries in your .NET applications.

## Installation

You can install the Bespoke libraries via NuGet:

```
dotnet add package Bespoke.Core
dotnet add package Bespoke.Logging
dotnet add package Bespoke.Messaging
```

## Basic Usage

### Core Library

```csharp
using Bespoke.Core.Models;

// Create a new core model
var model = new CoreModel
{
    Id = Guid.NewGuid().ToString()
};

Console.WriteLine($"Created model with ID: {model.Id} at {model.CreatedAt}");
```

### Logging Library

```csharp
using Bespoke.Logging.Providers;

// Implement a custom log provider
public class ConsoleLogProvider : LogProvider
{
    public override void Log(string message, LogLevel level)
    {
        Console.WriteLine($"[{level}] {DateTime.UtcNow}: {message}");
    }
}

// Use the log provider
var logger = new ConsoleLogProvider();
logger.LogInformation("Application started");
logger.LogWarning("This is a warning message");
logger.LogError("This is an error message");
```

### Messaging Library

```csharp
using Bespoke.Messaging.Models;

// Create a new message
var message = new Message
{
    Id = Guid.NewGuid().ToString(),
    Subject = "Test Message",
    Body = "This is a test message",
    SenderAddress = "sender@example.com",
    RecipientAddresses = new List<string> { "recipient@example.com" }
};

Console.WriteLine($"Created message: {message.Id}");
Console.WriteLine($"Subject: {message.Subject}");
```

## Demo Applications

Check out the demo applications in the `demo` folder for more examples of how to use the Bespoke libraries:

- DemoApp1: Demonstrates the use of Bespoke.Core and Bespoke.Logging
- DemoApp2: Demonstrates the use of Bespoke.Core and Bespoke.Messaging

## Running Tests

To run the unit tests for the Bespoke libraries:

```
dotnet test
```

## Documentation Website

For more detailed documentation, you can run the documentation website:

```
cd docs/website
dotnet run
```

Then navigate to `https://localhost:5001` in your web browser.
