#nullable enable

using Bespoke.Azure.Builders;
using Bespoke.Azure.Queue.Builders;
using Bespoke.Azure.Queue.Factories;
using Bespoke.Azure.Queue.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Bespoke.Azure.Queue.Extensions;

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