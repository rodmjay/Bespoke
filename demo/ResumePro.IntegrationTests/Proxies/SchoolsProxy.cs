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

public sealed class SchoolsProxy : BaseProxy, ISchoolsController
{
    public SchoolsProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public  Task<List<SchoolDetails>> GetSchools(int personId)
    {
        throw new NotImplementedException();
    }

    public  Task<SchoolDetails> GetSchool(int personId, int schoolId)
    {
        throw new NotImplementedException();
    }

    public Task<ActionResult<SchoolDetails>> UpdateSchool(int personId, int schoolId, SchoolOptions options)
    {
        throw new NotImplementedException();
    }

    public Task<Result> DeleteSchool(int personId, int schoolId)
    {
        throw new NotImplementedException();
    }

    public Task<ActionResult<SchoolDetails>> CreateSchool(int personId, SchoolOptions options)
    {
        throw new NotImplementedException();
    }
}