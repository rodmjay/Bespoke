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

public sealed class CompaniesProxy : BaseProxy, ICompaniesController
{
    public CompaniesProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task<List<CompanyDetails>> GetCompanies(int personId)
    {
        throw new NotImplementedException();
    }

    public async Task<CompanyDetails> GetCompany(int personId, int companyId)
    {
        throw new NotImplementedException();
    }

    public async Task<ActionResult<CompanyDetails>> CreateCompany(int personId, CompanyOptions options)
    {
        throw new NotImplementedException();
    }

    public async Task<ActionResult<CompanyDetails>> UpdateCompany(int personId, int companyId, CompanyOptions options)
    {
        throw new NotImplementedException();
    }

    public async Task<Result> DeleteCompany(int personId, int jobId)
    {
        throw new NotImplementedException();
    }
}