using NUnit.Framework;
using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace Bespoke.Bicep.Tests
{
    [TestFixture]
    public class BicepTemplateTests
    {
        private Assembly _bicepAssembly;
        private string[] _resourceNames;

        [SetUp]
        public void Setup()
        {
            _bicepAssembly = typeof(Bespoke.Bicep.BicepTemplateTests).Assembly;
            _resourceNames = _bicepAssembly.GetManifestResourceNames();
        }

        [TestFixture]
        public class ResourceExistenceTests : BicepTemplateTests
        {
            [Test]
            public void Should_Have_Embedded_Bicep_Resources()
            {
                Assert.IsNotEmpty(_resourceNames);
                Assert.IsTrue(_resourceNames.Any(r => r.EndsWith(".bicep")));
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class AppInsightsTemplateTests : BicepTemplateTests
        {
            [Test]
            public void Should_Load_AppInsights_Template()
            {
                var resourceName = _resourceNames.FirstOrDefault(r => r.EndsWith("appInsights.bicep"));
                Assert.IsNotNull(resourceName);
                
                using var stream = _bicepAssembly.GetManifestResourceStream(resourceName);
                using var reader = new StreamReader(stream);
                var content = reader.ReadToEnd();
                
                Assert.IsNotEmpty(content);
                Assert.IsTrue(content.Contains("resource appInsights"));
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class AppInsightsAlertTemplateTests : BicepTemplateTests
        {
            [Test]
            public void Should_Load_AppInsightsAlert_Template()
            {
                var resourceName = _resourceNames.FirstOrDefault(r => r.EndsWith("appInsightsAlert.bicep"));
                Assert.IsNotNull(resourceName);
                
                using var stream = _bicepAssembly.GetManifestResourceStream(resourceName);
                using var reader = new StreamReader(stream);
                var content = reader.ReadToEnd();
                
                Assert.IsNotEmpty(content);
                Assert.IsTrue(content.Contains("resource alertRule"));
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class AzureAdAppTemplateTests : BicepTemplateTests
        {
            [Test]
            public void Should_Load_AzureAdApp_Template()
            {
                var resourceName = _resourceNames.FirstOrDefault(r => r.EndsWith("azureAdApp.bicep"));
                Assert.IsNotNull(resourceName);
                
                using var stream = _bicepAssembly.GetManifestResourceStream(resourceName);
                using var reader = new StreamReader(stream);
                var content = reader.ReadToEnd();
                
                Assert.IsNotEmpty(content);
                Assert.IsTrue(content.Contains("resource azureAdApp"));
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class ContainerRegistryTemplateTests : BicepTemplateTests
        {
            [Test]
            public void Should_Load_ContainerRegistry_Template()
            {
                var resourceName = _resourceNames.FirstOrDefault(r => r.EndsWith("containerRegistry.bicep"));
                Assert.IsNotNull(resourceName);
                
                using var stream = _bicepAssembly.GetManifestResourceStream(resourceName);
                using var reader = new StreamReader(stream);
                var content = reader.ReadToEnd();
                
                Assert.IsNotEmpty(content);
                Assert.IsTrue(content.Contains("resource acr"));
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class LogAnalyticsWorkspaceTemplateTests : BicepTemplateTests
        {
            [Test]
            public void Should_Load_LogAnalyticsWorkspace_Template()
            {
                var resourceName = _resourceNames.FirstOrDefault(r => r.EndsWith("logAnalyticsWorkspace.bicep"));
                Assert.IsNotNull(resourceName);
                
                using var stream = _bicepAssembly.GetManifestResourceStream(resourceName);
                using var reader = new StreamReader(stream);
                var content = reader.ReadToEnd();
                
                Assert.IsNotEmpty(content);
                Assert.IsTrue(content.Contains("resource logAnalyticsWorkspace"));
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class ServiceBusTemplateTests : BicepTemplateTests
        {
            [Test]
            public void Should_Load_ServiceBus_Template()
            {
                var resourceName = _resourceNames.FirstOrDefault(r => r.EndsWith("serviceBus.bicep"));
                Assert.IsNotNull(resourceName);
                
                using var stream = _bicepAssembly.GetManifestResourceStream(resourceName);
                using var reader = new StreamReader(stream);
                var content = reader.ReadToEnd();
                
                Assert.IsNotEmpty(content);
                Assert.IsTrue(content.Contains("resource serviceBus"));
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class ServiceBusQueueTemplateTests : BicepTemplateTests
        {
            [Test]
            public void Should_Load_ServiceBusQueue_Template()
            {
                var resourceName = _resourceNames.FirstOrDefault(r => r.EndsWith("serviceBusQueue.bicep"));
                Assert.IsNotNull(resourceName);
                
                using var stream = _bicepAssembly.GetManifestResourceStream(resourceName);
                using var reader = new StreamReader(stream);
                var content = reader.ReadToEnd();
                
                Assert.IsNotEmpty(content);
                Assert.IsTrue(content.Contains("resource queue"));
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class ServiceBusTopicTemplateTests : BicepTemplateTests
        {
            [Test]
            public void Should_Load_ServiceBusTopic_Template()
            {
                var resourceName = _resourceNames.FirstOrDefault(r => r.EndsWith("serviceBusTopic.bicep"));
                Assert.IsNotNull(resourceName);
                
                using var stream = _bicepAssembly.GetManifestResourceStream(resourceName);
                using var reader = new StreamReader(stream);
                var content = reader.ReadToEnd();
                
                Assert.IsNotEmpty(content);
                Assert.IsTrue(content.Contains("resource topic"));
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class SqlDatabaseTemplateTests : BicepTemplateTests
        {
            [Test]
            public void Should_Load_SqlDatabase_Template()
            {
                var resourceName = _resourceNames.FirstOrDefault(r => r.EndsWith("sqlDatabase.bicep"));
                Assert.IsNotNull(resourceName);
                
                using var stream = _bicepAssembly.GetManifestResourceStream(resourceName);
                using var reader = new StreamReader(stream);
                var content = reader.ReadToEnd();
                
                Assert.IsNotEmpty(content);
                Assert.IsTrue(content.Contains("resource sqlDb"));
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class SqlFirewallRuleTemplateTests : BicepTemplateTests
        {
            [Test]
            public void Should_Load_SqlFirewallRule_Template()
            {
                var resourceName = _resourceNames.FirstOrDefault(r => r.EndsWith("sqlFirewallRule.bicep"));
                Assert.IsNotNull(resourceName);
                
                using var stream = _bicepAssembly.GetManifestResourceStream(resourceName);
                using var reader = new StreamReader(stream);
                var content = reader.ReadToEnd();
                
                Assert.IsNotEmpty(content);
                Assert.IsTrue(content.Contains("resource firewallRule"));
                Assert.IsTrue(true);
            }
        }

        [TestFixture]
        public class SqlServerTemplateTests : BicepTemplateTests
        {
            [Test]
            public void Should_Load_SqlServer_Template()
            {
                var resourceName = _resourceNames.FirstOrDefault(r => r.EndsWith("sqlServer.bicep"));
                Assert.IsNotNull(resourceName);
                
                using var stream = _bicepAssembly.GetManifestResourceStream(resourceName);
                using var reader = new StreamReader(stream);
                var content = reader.ReadToEnd();
                
                Assert.IsNotEmpty(content);
                Assert.IsTrue(content.Contains("resource sqlServer"));
                Assert.IsTrue(true);
            }
        }
    }
}
