using Bespoke.IntegrationTesting.Bases;
using Bespoke.Shared.Common;
using Microsoft.AspNetCore.Mvc;
using ResumePro.Api.Interfaces;
using ResumePro.Shared.Filters;
using ResumePro.Shared.Models;
using ResumePro.Shared.Options;

namespace ResumePro.IntegrationTests.Proxies;

public sealed class PeopleProxy : BaseProxy, IPeopleController
{
    public PeopleProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public Task<PagedList<PersonaDto>> GetPeople(PersonaFilters filters, PagingQuery paging)
    {
        throw new NotImplementedException();
    }

    public Task<PersonaDetails> GetPerson(int personId)
    {
        throw new NotImplementedException();
    }

    public Task<ActionResult<PersonaDetails>> CreatePerson(PersonOptions options)
    {
        throw new NotImplementedException();
    }

    public Task<ActionResult<PersonaDetails>> UpdatePerson(int personId, PersonOptions options)
    {
        throw new NotImplementedException();
    }

    public Task<Result> DeletePerson(int personId)
    {
        throw new NotImplementedException();
    }
}