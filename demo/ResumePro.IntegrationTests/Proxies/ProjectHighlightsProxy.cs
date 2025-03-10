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

public sealed class ProjectHighlightsProxy : BaseProxy, IProjectHighlightsController
{
    public ProjectHighlightsProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public  Task<HighlightDto> GetHighlight(int personId, int companyId, int positionId, int projectId, int highlightId)
    {
        throw new NotImplementedException();
    }

    public  Task<List<HighlightDto>> GetHighlights(int personId, int companyId, int positionId, int projectId)
    {
        throw new NotImplementedException();
    }

    public  Task<ActionResult<HighlightDto>> CreateHighlight(int personId, int companyId, int positionId, int projectId, HighlightOptions options)
    {
        throw new NotImplementedException();
    }

    public  Task<ActionResult<HighlightDto>> UpdateHighlight(int personId, int companyId, int positionId, int projectId, int highlightId,
        HighlightOptions options)
    {
        throw new NotImplementedException();
    }

    public  Task<Result> DeleteHighlight(int personId, int companyId, int positionId, int projectId, int highlightId)
    {
        throw new NotImplementedException();
    }
}