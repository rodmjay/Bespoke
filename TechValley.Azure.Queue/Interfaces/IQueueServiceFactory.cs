#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using TechValley.Azure.Queue.Services;

namespace TechValley.Azure.Queue.Interfaces;

public interface IQueueServiceFactory
{
    Task<QueueService> CreateQueueService(string queueName, bool autoCreate = true);
}