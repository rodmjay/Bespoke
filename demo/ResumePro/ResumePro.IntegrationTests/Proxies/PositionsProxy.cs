using Bespoke.IntegrationTesting.Bases;
using Bespoke.Shared.Common;
using Microsoft.AspNetCore.Mvc;
using ResumePro.Api.Interfaces;
using ResumePro.Shared.Models;
using ResumePro.Shared.Options;

namespace ResumePro.IntegrationTests.Proxies;

public sealed class PositionsProxy : BaseProxy, IPositionsController
{
    public PositionsProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public Task<ActionResult<CompanyDetails>> CreatePosition(int personId, int companyId, PositionOptions options)
    {
        throw new NotImplementedException();
    }

    public Task<ActionResult<CompanyDetails>> UpdatePosition(int personId, int companyId, int positionId, PositionOptions options)
    {
        throw new NotImplementedException();
    }

    public Task<Result> DeletePosition(int personId, int companyId, int positionId)
    {
        throw new NotImplementedException();
    }

    public Task<List<PositionDetails>> GetPositions(int personId, int companyId)
    {
        throw new NotImplementedException();
    }

    public Task<PositionDetails> GetPosition(int personId, int companyId, int positionId)
    {
        throw new NotImplementedException();
    }
}
