using Microsoft.Extensions.Configuration;
using TechValley.Azure.Builders;
using TechValley.Core.Builders;

namespace TechValley.Azure.Queue.Builders
{
    public class QueueStorageBuilder : BuilderBase
    {
        public QueueStorageBuilder(AzureBuilder builder) : base(builder)
        {
        }
    }
}
