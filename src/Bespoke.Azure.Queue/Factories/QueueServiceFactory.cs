#nullable enable

using System.Collections.Concurrent;
using Bespoke.Azure.Queue.Interfaces;
using Bespoke.Azure.Queue.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Bespoke.Azure.Queue.Factories;

public class QueueServiceFactory : IQueueServiceFactory
{
    private readonly ConcurrentDictionary<string, QueueService> _cache;
    private readonly string? _connectionString;
    private readonly ILogger<QueueService> _logger;
    private readonly IOptions<QueueStorageSettings> _queueSettings;

    public QueueServiceFactory(IOptions<QueueStorageSettings> queueSettings, IConfiguration configuration,
        IServiceProvider serviceProvider)
    {
        _queueSettings = queueSettings;
        _connectionString = configuration.GetConnectionString(queueSettings.Value.ConnectionStringName);
        _cache = new ConcurrentDictionary<string, QueueService>();
        _logger = serviceProvider.GetRequiredService<ILogger<QueueService>>();
    }

    public async Task<QueueService> CreateQueueService(string queueName, bool autoCreate = true)
    {
        if (!_cache.ContainsKey(queueName))
        {
            var queueService = new QueueService(_logger, _queueSettings.Value, _connectionString!, queueName);
            if (autoCreate) await queueService.CreateIfNotExistsAsync();
            _cache[queueName] = queueService;
        }

        return _cache[queueName];
    }
}