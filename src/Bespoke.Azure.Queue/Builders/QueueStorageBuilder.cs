using Bespoke.Azure.Builders;
using Bespoke.Core.Builders;

namespace Bespoke.Azure.Queue.Builders;

public class QueueStorageBuilder : BuilderBase
{
    public QueueStorageBuilder(AzureBuilder builder) : base(builder)
    {
    }
}