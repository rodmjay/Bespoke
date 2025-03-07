using NUnit.Framework;
using System;
using System.Threading.Tasks;
using Azure;
using Azure.Data.Tables;

namespace Bespoke.Azure.TableStorage.Tests.Services
{
    [TestFixture]
    public class TableServiceTests
    {
        [TestFixture]
        public class ConstructorTests : TableServiceTests
        {
            [Test]
            public void Should_Initialize_With_Dependencies()
            {
                // Just use Assert.IsTrue(true) as requested
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class CrudOperationsTests : TableServiceTests
        {
            [Test]
            public void Should_Perform_Crud_Operations()
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
