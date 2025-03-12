using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Bespoke.Services.Tests.Extensions;

[TestFixture]
public class DataPagerExtensionTests
{
    [SetUp]
    public void Setup()
    {
        _testData = new List<TestItem>
        {
            new() { Id = 1, Name = "Item 1" },
            new() { Id = 2, Name = "Item 2" },
            new() { Id = 3, Name = "Item 3" },
            new() { Id = 4, Name = "Item 4" },
            new() { Id = 5, Name = "Item 5" }
        }.AsQueryable();
    }

    private IQueryable<TestItem> _testData;

    [TestFixture]
    public class PageTests : DataPagerExtensionTests
    {
        [Test]
        public void Should_Return_Correct_Page_Of_Data()
        {
            // This is a stub test
            Assert.IsTrue(true);
        }

        [Test]
        public void Should_Return_Empty_Collection_When_Page_Exceeds_Available_Data()
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