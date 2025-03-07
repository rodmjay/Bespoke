using Microsoft.Extensions.DependencyInjection;
using TechValley.Azure.Builders;
using TechValley.Azure.Queue.Builders;
using TechValley.Azure.Queue.Factories;
using TechValley.Azure.Queue.Interfaces;

namespace TechValley.Azure.Queue.Extensions;

public static class QueueStorageExtensions
{
    public static AzureBuilder AddQueueStorage(this AzureBuilder builder, Action<QueueStorageBuilder>? build = default)
    {
        var queueBuilder = new QueueStorageBuilder(builder);

        builder.Services.AddSingleton<IQueueServiceFactory, QueueServiceFactory>();

        build?.Invoke(queueBuilder);

        return builder;
    }
}