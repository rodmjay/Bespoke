#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Bespoke.IntegrationTesting.Bases;
using Bespoke.Shared.Common;
using Microsoft.AspNetCore.Mvc;
using ResumePro.Api.Controllers;
using ResumePro.Shared.Filters;
using ResumePro.Shared.Helpers;
using ResumePro.Shared.Models;
using ResumePro.Shared.Options;

namespace ResumePro.IntegrationTests.Proxies;

public sealed class PeopleProxy : BaseProxy, IPeopleController
{
    public PeopleProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task<PagedList<PersonaDto>> GetPeople(PersonaFilters filters, PagingQuery paging)
    {
        throw new NotImplementedException();
    }

    public async Task<PersonaDetails> GetPerson(int personId)
    {
        throw new NotImplementedException();
    }

    public async Task<ActionResult<PersonaDetails>> CreatePerson(PersonOptions options)
    {
        throw new NotImplementedException();
    }

    public async Task<ActionResult<PersonaDetails>> UpdatePerson(int personId, PersonOptions options)
    {
        throw new NotImplementedException();
    }

    public async Task<Result> DeletePerson(int personId)
    {
        throw new NotImplementedException();
    }
}