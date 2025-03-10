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

public sealed class ProjectsProxy : BaseProxy, IProjectsController
{
    public ProjectsProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public Task<ProjectDetails> GetProject(int personId, int companyId, int positionId, int projectId)
    {
        throw new NotImplementedException();
    }

    public Task<List<ProjectDetails>> GetList(int personId, int companyId, int positionId)
    {
        throw new NotImplementedException();
    }

    public Task<ActionResult<ProjectDetails>> CreateProject(int personId, int companyId, int positionId, ProjectOptions options)
    {
        throw new NotImplementedException();
    }

    public Task<ActionResult<ProjectDetails>> Update(int personId, int companyId, int positionId, int projectId, ProjectOptions options)
    {
        throw new NotImplementedException();
    }

    public  Task<Result> Delete(int personId, int companyId, int positionId, int projectId)
    {
        throw new NotImplementedException();
    }
}