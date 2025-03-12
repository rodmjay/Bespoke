using Bespoke.IntegrationTesting.Bases;
using Bespoke.Shared.Common;
using Microsoft.AspNetCore.Mvc;
using ResumePro.Api.Interfaces;
using ResumePro.Shared.Models;
using ResumePro.Shared.Options;

namespace ResumePro.IntegrationTests.Proxies;

public sealed class ReferencesProxy : BaseProxy, IReferencesController
{
    public ReferencesProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public Task<ReferenceDto> Get(int personId, int referenceId)
    {
        throw new NotImplementedException();
    }

    public Task<List<ReferenceDto>> GetReferences(int personId)
    {
        throw new NotImplementedException();
    }

    public Task<ActionResult<ReferenceDto>> CreateReference(int personId, ReferenceOptions options)
    {
        throw new NotImplementedException();
    }

    public Task<ActionResult<ReferenceDto>> UpdateReference(int personId, int referenceId, ReferenceOptions options)
    {
        throw new NotImplementedException();
    }

    public Task<Result> DeleteReference(int personId, int referenceId)
    {
        throw new NotImplementedException();
    }
}