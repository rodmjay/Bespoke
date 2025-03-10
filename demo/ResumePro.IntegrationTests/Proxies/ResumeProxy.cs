#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Bespoke.IntegrationTesting.Bases;
using Bespoke.Shared.Common;
using Microsoft.AspNetCore.Mvc;
using ResumePro.Api.Controllers;
using ResumePro.Shared.Models;
using ResumePro.Shared.Options;

namespace ResumePro.IntegrationTests.Proxies;

public sealed class ResumeProxy : BaseProxy, IResumeController
{
    public ResumeProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public  Task<ResumeDetails> GetResume(int personId, int resumeId)
    {
        throw new NotImplementedException();
    }

    public  Task<List<ResumeDto>> GetResumes(int personId)
    {
        throw new NotImplementedException();
    }

    public  Task<ActionResult<ResumeDetails>> CreateResume(int personId, ResumeOptions options)
    {
        throw new NotImplementedException();
    }

    public  Task<ActionResult<ResumeDetails>> UpdateResume(int personId, int resumeId, ResumeOptions options)
    {
        throw new NotImplementedException();
    }

    public  Task<Result> DeleteResume(int personId, int resumeId)
    {
        throw new NotImplementedException();
    }
}