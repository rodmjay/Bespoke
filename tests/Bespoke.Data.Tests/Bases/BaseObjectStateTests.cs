using NUnit.Framework;
using Bespoke.Data.Bases;
using Bespoke.Data.Enums;
using System;

namespace Bespoke.Data.Tests.Bases
{
    [TestFixture]
    public class BaseObjectStateTests
    {
        [TestFixture]
        public class ConstructorTests : BaseObjectStateTests
        {
            [Test]
            public void Should_Initialize_With_Default_Values()
            {
                var objectState = new TestBaseObjectState();
                Assert.NotNull(objectState);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class ObjectStateTests : BaseObjectStateTests
        {
            [Test]
            public void Should_Set_And_Get_Value_Correctly()
            {
                var objectState = new TestBaseObjectState();
                objectState.ObjectState = ObjectState.Added;
                Assert.AreEqual(ObjectState.Added, objectState.ObjectState);
                Assert.IsTrue(true);
            }
        }

        // Test class that inherits from BaseObjectState for testing
        private class TestBaseObjectState : BaseObjectState
        {
        }
    }
}
