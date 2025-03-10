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

public sealed class ReferencesProxy : BaseProxy, IReferencesController
{
    public ReferencesProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task<ReferenceDto> Get(int personId, int referenceId)
    {
        throw new NotImplementedException();
    }

    public async Task<List<ReferenceDto>> GetReferences(int personId)
    {
        throw new NotImplementedException();
    }

    public async Task<ActionResult<ReferenceDto>> CreateReference(int personId, ReferenceOptions options)
    {
        throw new NotImplementedException();
    }

    public async Task<ActionResult<ReferenceDto>> UpdateReference(int personId, int referenceId, ReferenceOptions options)
    {
        throw new NotImplementedException();
    }

    public async Task<Result> DeleteReference(int personId, int referenceId)
    {
        throw new NotImplementedException();
    }
}