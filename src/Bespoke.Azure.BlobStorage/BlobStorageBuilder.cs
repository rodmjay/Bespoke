using Bespoke.Azure.Builders;
using Bespoke.Core.Builders;

namespace Bespoke.Azure.BlobStorage;

public class BlobStorageBuilder : BuilderBase
{
    public BlobStorageBuilder(AzureBuilder builder) : base(builder)
    {
    }
}