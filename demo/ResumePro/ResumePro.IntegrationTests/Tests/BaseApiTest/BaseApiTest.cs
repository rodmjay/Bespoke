using Bespoke.IntegrationTesting.Bases;
using NUnit.Framework;
using ResumePro.Api;
using ResumePro.Api.Interfaces;
using ResumePro.IntegrationTests.Proxies;

namespace ResumePro.IntegrationTests.Tests;

public abstract partial class BaseApiTest : IntegrationTest<BaseApiTest, Startup>
{
    // todo:devin add proxy for each controller interface like... Any interface that ends with Controller in the ResumePro.Api.Interfaces
    protected IResumeController ResumeController => new ResumeProxy(ApiClient);

    [OneTimeSetUp]
    public virtual async Task SetupFixture()
    {
        await ResetDatabase();
    }

    [OneTimeTearDown]
    public virtual async Task TeardownFixture()
    {
        await DeleteDatabase();
    }
}