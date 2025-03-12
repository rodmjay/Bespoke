using Bespoke.IntegrationTesting.Bases;
using ResumePro.Api.Interfaces;
using ResumePro.Shared.Models;

namespace ResumePro.IntegrationTests.Proxies;

public sealed class PersonLanguagesProxy : BaseProxy, IPersonLanguagesController
{
    private const string RootUrl = "v1.0/people/{0}/languages";

    public PersonLanguagesProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task<List<PersonaLanguageDto>> GetPersonLanguages(int personId)
    {
        return await DoGetAsync<List<PersonaLanguageDto>>(string.Format(RootUrl, personId));
    }
}
