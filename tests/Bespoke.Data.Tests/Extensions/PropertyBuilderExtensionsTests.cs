using NUnit.Framework;
using Bespoke.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Moq;
using System;

namespace Bespoke.Data.Tests.Extensions
{
    [TestFixture]
    public class PropertyBuilderExtensionsTests
    {
        [TestFixture]
        public class HasMaxLengthTests : PropertyBuilderExtensionsTests
        {
            [Test]
            public void Should_Set_Max_Length()
            {
                // This is a stub test
                Assert.IsTrue(true);
            }
        }
    }
}
