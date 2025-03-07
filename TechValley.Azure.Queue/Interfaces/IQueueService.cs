#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

namespace TechValley.Azure.Queue.Interfaces;

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