﻿#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion


using Bespoke.IntegrationTesting.Bases;
using Bespoke.Shared.Common;
using ResumePro.Api.Controllers;

namespace ResumePro.IntegrationTests.Proxies;

public sealed class ResumeSkillsProxy : BaseProxy, IResumeSkillsController
{
    public ResumeSkillsProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task<Result> AddResumeSkill(int personId, int resumeId, int skillId)
    {
        throw new NotImplementedException();
    }

    public async Task<Result> DeleteResumeSkill(int personId, int resumeId, int skillId)
    {
        throw new NotImplementedException();
    }
}