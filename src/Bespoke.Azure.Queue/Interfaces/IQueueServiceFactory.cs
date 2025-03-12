using Bespoke.Azure.Queue.Services;

namespace Bespoke.Azure.Queue.Interfaces;

public interface IQueueServiceFactory
{
    Task<QueueService> CreateQueueService(string queueName, bool autoCreate = true);
}