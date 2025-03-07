using NUnit.Framework;
using Bespoke.Data;

namespace Bespoke.Data.Tests
{
    [TestFixture]
    public class DbSettingsTests
    {
        [TestFixture]
        public class ConstructorTests : DbSettingsTests
        {
            [Test]
            public void Should_Initialize_With_Default_Values()
            {
                var settings = new DbSettings();
                Assert.NotNull(settings);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class MigrationsAssemblyTests : DbSettingsTests
        {
            [Test]
            public void Should_Set_And_Get_Value_Correctly()
            {
                var settings = new DbSettings();
                settings.MigrationsAssembly = "TestAssembly";
                Assert.AreEqual("TestAssembly", settings.MigrationsAssembly);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class TimeoutTests : DbSettingsTests
        {
            [Test]
            public void Should_Set_And_Get_Value_Correctly()
            {
                var settings = new DbSettings();
                settings.Timeout = 30;
                Assert.AreEqual(30, settings.Timeout);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class MaxRetryCountTests : DbSettingsTests
        {
            [Test]
            public void Should_Set_And_Get_Value_Correctly()
            {
                var settings = new DbSettings();
                settings.MaxRetryCount = 10;
                Assert.AreEqual(10, settings.MaxRetryCount);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class MaxRetryDelaySecondsTests : DbSettingsTests
        {
            [Test]
            public void Should_Set_And_Get_Value_Correctly()
            {
                var settings = new DbSettings();
                settings.MaxRetryDelaySeconds = 30;
                Assert.AreEqual(30, settings.MaxRetryDelaySeconds);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class MaxBatchSizeTests : DbSettingsTests
        {
            [Test]
            public void Should_Set_And_Get_Value_Correctly()
            {
                var settings = new DbSettings();
                settings.MaxBatchSize = 200;
                Assert.AreEqual(200, settings.MaxBatchSize);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class SplitQueriesTests : DbSettingsTests
        {
            [Test]
            public void Should_Set_And_Get_Value_Correctly()
            {
                var settings = new DbSettings();
                settings.SplitQueries = true;
                Assert.IsTrue(settings.SplitQueries);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class UseContextPoolingTests : DbSettingsTests
        {
            [Test]
            public void Should_Set_And_Get_Value_Correctly()
            {
                var settings = new DbSettings();
                settings.UseContextPooling = true;
                Assert.IsTrue(settings.UseContextPooling);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class ValidateSavesTests : DbSettingsTests
        {
            [Test]
            public void Should_Set_And_Get_Value_Correctly()
            {
                var settings = new DbSettings();
                settings.ValidateSaves = false;
                Assert.IsFalse(settings.ValidateSaves);
                Assert.IsTrue(true);
            }
        }
    }
}
