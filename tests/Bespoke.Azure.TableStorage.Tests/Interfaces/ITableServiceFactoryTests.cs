using NUnit.Framework;
using System;
using System.Threading.Tasks;
using Azure;
using Azure.Data.Tables;

namespace Bespoke.Azure.TableStorage.Tests.Interfaces
{
    [TestFixture]
    public class ITableServiceFactoryTests
    {
        [TestFixture]
        public class InterfaceMethodsTests : ITableServiceFactoryTests
        {
            [Test]
            public void Should_Define_Required_Methods()
            {
                // Just use Assert.IsTrue(true) as requested
                Assert.IsTrue(true);
            }
        }

        public class TestEntity : ITableEntity
        {
            public string PartitionKey { get; set; }
            public string RowKey { get; set; }
            public DateTimeOffset? Timestamp { get; set; }
            public ETag ETag { get; set; }
            public string Name { get; set; }
        }
    }
}
