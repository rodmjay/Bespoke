using Microsoft.Extensions.Configuration;
using TechValley.Azure.Builders;
using TechValley.Core.Builders;

namespace TechValley.Azure.BlobStorage
{
    public class BlobStorageBuilder : BuilderBase
    {
        public BlobStorageBuilder(AzureBuilder builder) : base(builder)
        {
        }
    }
}
