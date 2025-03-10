#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Bespoke.IntegrationTesting.Bases;
using Microsoft.AspNetCore.Mvc;
using ResumePro.Api.Controllers;
using ResumePro.Shared.Models;
using ResumePro.Shared.Options;

namespace ResumePro.IntegrationTests.Proxies;

public sealed class ResumeSettingsProxy : BaseProxy, IResumeSettingsController
{
    public ResumeSettingsProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public Task<ActionResult<ResumeSettingsDto>> UpdateSettings(int personId, int resumeId, ResumeSettingsOptions options)
    {
        throw new NotImplementedException();
    }
}