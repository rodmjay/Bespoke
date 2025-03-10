#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Bespoke.IntegrationTesting.Bases;
using ResumePro.Api.Controllers;
using ResumePro.Shared.Models;

namespace ResumePro.IntegrationTests.Proxies;

public sealed class PersonLanguagesProxy : BaseProxy, IPersonLanguagesController
{
    public PersonLanguagesProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task<List<PersonaLanguageDto>> GetPersonLanguages(int personId)
    {
        throw new NotImplementedException();
    }
}