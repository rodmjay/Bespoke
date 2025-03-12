using NUnit.Framework;
using ResumePro.Shared.Models;
using Bespoke.IntegrationTesting.Extensions;

namespace ResumePro.IntegrationTests.Tests
{
    public abstract partial class BaseApiTest
    {
        protected async Task<FilterContainer> AssertGetFilters()
        {
            var filters = await FiltersController.GetFilters();
            Assert.That(filters, Is.Not.Null, "Failed to retrieve filters");
            return filters;
        }
    }
}
