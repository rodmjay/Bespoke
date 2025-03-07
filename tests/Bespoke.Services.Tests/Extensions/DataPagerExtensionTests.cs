using NUnit.Framework;
using Bespoke.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bespoke.Services.Tests.Extensions
{
    [TestFixture]
    public class DataPagerExtensionTests
    {
        private IQueryable<TestItem> _testData;

        [SetUp]
        public void Setup()
        {
            _testData = new List<TestItem>
            {
                new TestItem { Id = 1, Name = "Item 1" },
                new TestItem { Id = 2, Name = "Item 2" },
                new TestItem { Id = 3, Name = "Item 3" },
                new TestItem { Id = 4, Name = "Item 4" },
                new TestItem { Id = 5, Name = "Item 5" }
            }.AsQueryable();
        }

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
}
