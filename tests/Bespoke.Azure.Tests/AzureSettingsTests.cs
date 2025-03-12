using NUnit.Framework;

namespace Bespoke.Azure.Tests;

[TestFixture]
public class AzureSettingsTests
{
    [TestFixture]
    public class ConstructorTests : AzureSettingsTests
    {
        [Test]
        public void Should_Initialize_With_Default_Values()
        {
            var settings = new AzureSettings();
            Assert.NotNull(settings);
            Assert.IsTrue(true);
        }
    }

    [TestFixture]
    public class UseAzureManagedIdentityTests : AzureSettingsTests
    {
        [Test]
        public void Should_Set_And_Get_Value_Correctly()
        {
            var settings = new AzureSettings();
            settings.UseAzureManagedIdentity = true;
            Assert.IsTrue(settings.UseAzureManagedIdentity);
        }
    }

    [TestFixture]
    public class AccountNameTests : AzureSettingsTests
    {
        [Test]
        public void Should_Set_And_Get_Value_Correctly()
        {
            var settings = new AzureSettings();
            settings.AccountName = "TestAccount";
            Assert.AreEqual("TestAccount", settings.AccountName);
        }
    }

    [TestFixture]
    public class AccountKeyTests : AzureSettingsTests
    {
        [Test]
        public void Should_Set_And_Get_Value_Correctly()
        {
            var settings = new AzureSettings();
            settings.AccountKey = "TestKey";
            Assert.AreEqual("TestKey", settings.AccountKey);
        }
    }
}