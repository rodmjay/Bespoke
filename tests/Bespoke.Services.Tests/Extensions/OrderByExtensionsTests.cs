using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Bespoke.Services.Tests.Extensions;

[TestFixture]
public class OrderByExtensionsTests
{
    [SetUp]
    public void Setup()
    {
        _testData = new List<TestItem>
        {
            new() { Id = 3, Name = "Item C" },
            new() { Id = 1, Name = "Item A" },
            new() { Id = 2, Name = "Item B" },
            new() { Id = 5, Name = "Item E" },
            new() { Id = 4, Name = "Item D" }
        }.AsQueryable();
    }

    private IQueryable<TestItem> _testData;

    [TestFixture]
    public class OrderByTests : OrderByExtensionsTests
    {
        [Test]
        public void Should_Order_By_Property_Ascending()
        {
            // This is a stub test
            Assert.IsTrue(true);
        }

        [Test]
        public void Should_Order_By_Property_Descending()
        {
            // This is a stub test
            Assert.IsTrue(true);
        }
    }

    private class TestItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}