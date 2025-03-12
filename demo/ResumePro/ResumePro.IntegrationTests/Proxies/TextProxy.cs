using Bespoke.IntegrationTesting.Bases;
using Microsoft.AspNetCore.Mvc;
using ResumePro.Api.Interfaces;
using ResumePro.Shared.Models;
using ResumePro.Shared.Options;

namespace ResumePro.IntegrationTests.Proxies;

public sealed class TextProxy : BaseProxy, ITextController
{
    public TextProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public Task<ChatResult> Professionalize([FromBody] ChatOptions options)
    {
        throw new NotImplementedException();
    }
}
