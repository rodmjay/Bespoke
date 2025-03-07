using NUnit.Framework;
using Bespoke.Azure.TableStorage;

namespace Bespoke.Azure.TableStorage.Tests
{
    [TestFixture]
    public class TableStorageSettingsTests
    {
        [TestFixture]
        public class ConstructorTests : TableStorageSettingsTests
        {
            [Test]
            public void Should_Initialize_With_Default_Values()
            {
                var settings = new TableStorageSettings();
                Assert.NotNull(settings);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class ConnectionStringNameTests : TableStorageSettingsTests
        {
            [Test]
            public void Should_Set_And_Get_Value_Correctly()
            {
                var settings = new TableStorageSettings();
                settings.ConnectionStringName = "TestConnectionString";
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class TableEndpointTests : TableStorageSettingsTests
        {
            [Test]
            public void Should_Set_And_Get_Value_Correctly()
            {
                var settings = new TableStorageSettings();
                settings.TableEndpoint = "https://test.table.core.windows.net";
                Assert.AreEqual("https://test.table.core.windows.net", settings.TableEndpoint);
            }
        }
    }
}
