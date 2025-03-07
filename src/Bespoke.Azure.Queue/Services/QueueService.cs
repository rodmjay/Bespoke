using Azure;
using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;
using Bespoke.Azure.Queue.Interfaces;

namespace Bespoke.Azure.Queue.Services;

public class QueueService : IQueueService
{
    protected string GetLogMessage(string message, [CallerMemberName] string callerName = null)
    {
        var className = GetType().Name;
        return $"[{className}.{callerName}] - {message}";
    }

    private readonly QueueStorageSettings _queueSettings;
    private readonly string _connectionString;
    private readonly string queueName;

    public QueueService(ILogger<QueueService> logger, QueueStorageSettings queueSettings, string connectionString, string queueName)
    {
        _queueSettings = queueSettings;
        _connectionString = connectionString;
        this.queueName = queueName;
    }

    public async Task CreateIfNotExistsAsync()
    {
        QueueClient queueClient = new QueueClient(_connectionString, queueName);
        await queueClient.CreateIfNotExistsAsync();
        Console.WriteLine($"Queue '{queueName}' is ready.");
    }

    public async Task AddMessageAsync( string message)
    {
        QueueClient queueClient = new QueueClient(_connectionString, queueName);
        await queueClient.SendMessageAsync(message);
        Console.WriteLine($"Message added to queue '{queueName}': {message}");
    }


    // Peek a message from the queue (Read - but doesn't remove)
    public async Task PeekMessageAsync()
    {
        var queueClient = new QueueClient(_connectionString, queueName);
        Response<PeekedMessage[]> peekedMessages = await queueClient.PeekMessagesAsync(1);
        if (peekedMessages.Value.Length > 0)
        {
            Console.WriteLine($"Peeked Message from '{queueName}': {peekedMessages.Value[0].MessageText}");
        }
        else
        {
            Console.WriteLine($"No messages to peek in queue '{queueName}'.");
        }
    }

    // Get and Dequeue (Read and Remove) a message
    public async Task GetMessageAsync()
    {
        var queueClient = new QueueClient(_connectionString, queueName);
        QueueMessage[] retrievedMessages = await queueClient.ReceiveMessagesAsync(1);
        if (retrievedMessages.Length > 0)
        {
            QueueMessage message = retrievedMessages[0];
            Console.WriteLine($"Retrieved Message from '{queueName}': {message.MessageText}");

            // Delete the message after processing (Delete)
            await queueClient.DeleteMessageAsync(message.MessageId, message.PopReceipt);
            Console.WriteLine($"Message deleted from queue '{queueName}'.");
        }
        else
        {
            Console.WriteLine($"No messages to retrieve from queue '{queueName}'.");
        }
    }

    // Update a message (this will delete and add a new one since Queue Storage doesn't support direct update)
    public async Task UpdateMessageAsync(string oldMessageText, string newMessageText)
    {
        var queueClient = new QueueClient(_connectionString, queueName);
        QueueMessage[] retrievedMessages = await queueClient.ReceiveMessagesAsync(10);  // Retrieves up to 10 messages
        foreach (var message in retrievedMessages)
        {
            if (message.MessageText == oldMessageText)
            {
                // Delete the old message
                await queueClient.DeleteMessageAsync(message.MessageId, message.PopReceipt);
                Console.WriteLine($"Old message '{oldMessageText}' deleted from '{queueName}'.");

                // Add the new message
                await queueClient.SendMessageAsync(newMessageText);
                Console.WriteLine($"New message '{newMessageText}' added to '{queueName}'.");
                return;
            }
        }

        Console.WriteLine($"Message '{oldMessageText}' not found for update in queue '{queueName}'.");
    }

    // Delete a specific message from the queue
    public async Task DeleteMessageAsync(string messageId, string popReceipt)
    {
        var queueClient = new QueueClient(_connectionString, queueName);
        await queueClient.DeleteMessageAsync(messageId, popReceipt);
        Console.WriteLine($"Message with ID '{messageId}' deleted from queue '{queueName}'.");
    }

    // Clear all messages in the queue
    public async Task ClearQueueAsync()
    {
        var queueClient = new QueueClient(_connectionString, queueName);
        await queueClient.ClearMessagesAsync();
        Console.WriteLine($"All messages cleared from queue '{queueName}'.");
    }

}