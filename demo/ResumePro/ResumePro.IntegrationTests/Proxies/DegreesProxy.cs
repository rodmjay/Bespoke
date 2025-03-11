#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Bespoke.IntegrationTesting.Bases;
using Bespoke.Shared.Common;
using Microsoft.AspNetCore.Mvc;
using ResumePro.Api.Interfaces;
using ResumePro.Shared.Models;
using ResumePro.Shared.Options;

namespace ResumePro.IntegrationTests.Proxies;

public sealed class DegreesProxy : BaseProxy, IDegreesController
{
    public DegreesProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public  Task<DegreeDto> GetDegree(int personId, int schoolId, int degreeId)
    {
        throw new NotImplementedException();
    }

    public Task<List<DegreeDto>> GetDegrees(int personId, int schoolId)
    {
        throw new NotImplementedException(); 
    }

    public Task<ActionResult<DegreeDto>> UpdateDegree(int personId, int schoolId, int degreeId, DegreeOptions options)
    {
        throw new NotImplementedException();
    }

    public Task<Result> DeleteDegree(int personId, int schoolId, int degreeId)
    {
        throw new NotImplementedException();
    }

    public Task<ActionResult<DegreeDto>> CreateDegree(int personId, int schoolId, DegreeOptions options)
    {
        throw new NotImplementedException();
    }
}