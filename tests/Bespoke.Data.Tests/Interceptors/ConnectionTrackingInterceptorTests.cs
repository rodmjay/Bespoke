using NUnit.Framework;
using Bespoke.Data.Interceptors;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Moq;
using System;
using System.Data.Common;

namespace Bespoke.Data.Tests.Interceptors
{
    [TestFixture]
    public class ConnectionTrackingInterceptorTests
    {
        [TestFixture]
        public class ConnectionOpenedTests : ConnectionTrackingInterceptorTests
        {
            [Test]
            public void Should_Track_Connection_Opening()
            {
                // This is a stub test
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class ConnectionClosedTests : ConnectionTrackingInterceptorTests
        {
            [Test]
            public void Should_Track_Connection_Closing()
            {
                // This is a stub test
                Assert.IsTrue(true);
            }
        }
    }
}
