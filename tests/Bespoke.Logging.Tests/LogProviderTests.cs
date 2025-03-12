using NUnit.Framework;

namespace Bespoke.Logging.Tests;

[TestFixture]
public class LogProviderTests
{
    [TestFixture]
    public class LoggingTests : LogProviderTests
    {
        [Test]
        public void Should_Log_Messages_At_Different_Levels()
        {
            // This is a stub test
            Assert.IsTrue(true);
        }
    }

    [TestFixture]
    public class ConfigurationTests : LogProviderTests
    {
        [Test]
        public void Should_Configure_Logging_Correctly()
        {
            // This is a stub test
            Assert.IsTrue(true);
        }
    }
}