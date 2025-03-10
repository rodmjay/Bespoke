#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Bespoke.IntegrationTesting.Bases;
using Microsoft.AspNetCore.Mvc;
using ResumePro.Api.Controllers;
using ResumePro.Shared.Models;
using ResumePro.Shared.Options;

namespace ResumePro.IntegrationTests.Proxies;

public sealed class OrganizationSettingsProxy : BaseProxy, IOrganizationSettingsController
{
    public OrganizationSettingsProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public Task<ActionResult<OrganizationSettingsDto>> CreateSettings(OrganizationSettingsOptions options)
    {
        throw new NotImplementedException();
    }

    public Task<ActionResult<OrganizationSettingsDto>> UpdateSettings(OrganizationSettingsOptions options)
    {
        throw new NotImplementedException();
    }
}