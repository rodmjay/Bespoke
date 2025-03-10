#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Bespoke.IntegrationTesting.Bases;
using Microsoft.AspNetCore.Mvc;
using ResumePro.Api.Interfaces;
using ResumePro.Shared.Models;
using ResumePro.Shared.Options;

namespace ResumePro.IntegrationTests.Proxies;

public sealed class TemplatesProxy : BaseProxy, ITemplatesController
{
    public TemplatesProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public  Task<List<TemplateDto>> GetTemplates()
    {
        throw new NotImplementedException();
    }

    public  Task<ActionResult<TemplateDto>> CreateTemplate(TemplateOptions options)
    {
        throw new NotImplementedException();
    }

    public  Task<ActionResult<TemplateDto>> UpdateTemplate(int templateId, TemplateOptions options)
    {
        throw new NotImplementedException();
    }
}