#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Bespoke.IntegrationTesting.Bases;
using Bespoke.Shared.Common;
using ResumePro.Api.Controllers;
using ResumePro.Shared.Models;

namespace ResumePro.IntegrationTests.Proxies;

public sealed class PersonSkillsProxy : BaseProxy, IPersonSkillsController
{
    public PersonSkillsProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task<List<PersonaSkillDto>> GetSkills(int personId)
    {
        throw new NotImplementedException();
    }

    public async Task<Result> ToggleSkill(int personId, int skillId)
    {
        throw new NotImplementedException();
    }
}