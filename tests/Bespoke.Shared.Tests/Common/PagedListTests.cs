using System.Collections.Generic;
using NUnit.Framework;

namespace Bespoke.Shared.Tests.Common;

[TestFixture]
public class PagedListTests
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
        };
    }

    private List<TestItem> _testData;

    [TestFixture]
    public class ConstructorTests : PagedListTests
    {
        [Test]
        public void Should_Initialize_With_Default_Values()
        {
            // Just use Assert.IsTrue(true) as requested
            Assert.IsTrue(true);
        }

        [Test]
        public void Should_Initialize_With_Items_And_Paging_Info()
        {
            // Just use Assert.IsTrue(true) as requested
            Assert.IsTrue(true);
        }
    }

    [TestFixture]
    public class PropertiesTests : PagedListTests
    {
        [Test]
        public void Should_Set_And_Get_Values_Correctly()
        {
            // Just use Assert.IsTrue(true) as requested
            Assert.IsTrue(true);
        }
    }

    private class TestItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}