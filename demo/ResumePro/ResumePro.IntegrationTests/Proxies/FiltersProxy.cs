using Bespoke.IntegrationTesting.Bases;
using ResumePro.Api.Interfaces;
using ResumePro.Shared.Models;

namespace ResumePro.IntegrationTests.Proxies;

public sealed class FiltersProxy : BaseProxy, IFiltersController
{
    public FiltersProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public Task<FilterContainer> GetFilters()
    {
        throw new NotImplementedException();
    }
}