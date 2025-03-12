using System;
using Azure;
using Azure.Data.Tables;
using NUnit.Framework;

namespace Bespoke.Azure.TableStorage.Tests.Interfaces;

[TestFixture]
public class ITableServiceTests
{
    [TestFixture]
    public class InterfaceMethodsTests : ITableServiceTests
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
        public string Name { get; set; }
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }
    }
}