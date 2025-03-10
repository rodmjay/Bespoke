﻿#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Bespoke.IntegrationTesting.Bases;
using ResumePro.Api.Interfaces;
using ResumePro.Shared.Models;

namespace ResumePro.IntegrationTests.Proxies;

public sealed class SkillsProxy : BaseProxy, ISkillsController
{
    public SkillsProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public Task<List<SkillDto>> GetSkills()
    {
        throw new NotImplementedException();
    }
}