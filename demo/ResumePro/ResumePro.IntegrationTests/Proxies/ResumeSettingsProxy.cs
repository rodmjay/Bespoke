using Bespoke.IntegrationTesting.Bases;
using Microsoft.AspNetCore.Mvc;
using ResumePro.Api.Interfaces;
using ResumePro.Shared.Models;
using ResumePro.Shared.Options;

namespace ResumePro.IntegrationTests.Proxies;

public sealed class ResumeSettingsProxy : BaseProxy, IResumeSettingsController
{
    public ResumeSettingsProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public Task<ActionResult<ResumeSettingsDto>> UpdateSettings(int personId, int resumeId,
        ResumeSettingsOptions options)
    {
        throw new NotImplementedException();
    }
}