using NUnit.Framework;
using Bespoke.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bespoke.Services.Tests.Extensions
{
    [TestFixture]
    public class OrderByExtensionsTests
    {
        private IQueryable<TestItem> _testData;

        [SetUp]
        public void Setup()
        {
            _testData = new List<TestItem>
            {
                new TestItem { Id = 3, Name = "Item C" },
                new TestItem { Id = 1, Name = "Item A" },
                new TestItem { Id = 2, Name = "Item B" },
                new TestItem { Id = 5, Name = "Item E" },
                new TestItem { Id = 4, Name = "Item D" }
            }.AsQueryable();
        }

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
}
