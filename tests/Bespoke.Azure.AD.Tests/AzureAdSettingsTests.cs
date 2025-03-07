using NUnit.Framework;
using Bespoke.Azure.AD;

namespace Bespoke.Azure.AD.Tests
{
    [TestFixture]
    public class AzureAdSettingsTests
    {
        [TestFixture]
        public class ConstructorTests : AzureAdSettingsTests
        {
            [Test]
            public void Should_Initialize_With_Default_Values()
            {
                var settings = new AzureAdSettings();
                Assert.NotNull(settings);
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class InstanceTests : AzureAdSettingsTests
        {
            [Test]
            public void Should_Set_And_Get_Value_Correctly()
            {
                var settings = new AzureAdSettings();
                settings.Instance = "TestInstance";
                Assert.AreEqual("TestInstance", settings.Instance);
            }
        }

        [TestFixture]
        public class DomainTests : AzureAdSettingsTests
        {
            [Test]
            public void Should_Set_And_Get_Value_Correctly()
            {
                var settings = new AzureAdSettings();
                settings.Domain = "TestDomain";
                Assert.AreEqual("TestDomain", settings.Domain);
            }
        }

        [TestFixture]
        public class TenantIdTests : AzureAdSettingsTests
        {
            [Test]
            public void Should_Set_And_Get_Value_Correctly()
            {
                var settings = new AzureAdSettings();
                settings.TenantId = "TestTenantId";
                Assert.AreEqual("TestTenantId", settings.TenantId);
            }
        }

        [TestFixture]
        public class ClientIdTests : AzureAdSettingsTests
        {
            [Test]
            public void Should_Set_And_Get_Value_Correctly()
            {
                var settings = new AzureAdSettings();
                settings.ClientId = "TestClientId";
                Assert.AreEqual("TestClientId", settings.ClientId);
            }
        }

        [TestFixture]
        public class CallbackPathTests : AzureAdSettingsTests
        {
            [Test]
            public void Should_Set_And_Get_Value_Correctly()
            {
                var settings = new AzureAdSettings();
                settings.CallbackPath = "TestCallbackPath";
                Assert.AreEqual("TestCallbackPath", settings.CallbackPath);
            }
        }
    }
}
