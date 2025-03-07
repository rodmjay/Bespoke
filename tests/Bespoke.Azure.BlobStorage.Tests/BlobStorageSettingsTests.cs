using NUnit.Framework;
using Bespoke.Azure.BlobStorage;

namespace Bespoke.Azure.BlobStorage.Tests
{
    [TestFixture]
    public class BlobStorageSettingsTests
    {
        [TestFixture]
        public class ConstructorTests : BlobStorageSettingsTests
        {
            [Test]
            public void Should_Initialize_With_Default_Values()
            {
                var settings = new BlobStorageSettings();
                Assert.NotNull(settings);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class ConnectionStringNameTests : BlobStorageSettingsTests
        {
            [Test]
            public void Should_Set_And_Get_Value_Correctly()
            {
                var settings = new BlobStorageSettings();
                settings.ConnectionStringName = "TestConnectionString";
                Assert.AreEqual("TestConnectionString", settings.ConnectionStringName);
            }
        }
    }
}
