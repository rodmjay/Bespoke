namespace Bespoke.Azure.Queue.Interfaces;

public interface IQueueService
{
    Task CreateIfNotExistsAsync();
    Task AddMessageAsync(string message);
    Task PeekMessageAsync();
    Task GetMessageAsync();
    Task UpdateMessageAsync(string oldMessageText, string newMessageText);
    Task DeleteMessageAsync(string messageId, string popReceipt);
    Task ClearQueueAsync();
}