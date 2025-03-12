using Bespoke.IntegrationTesting.Bases;
using Bespoke.Shared.Common;
using Microsoft.AspNetCore.Mvc;
using ResumePro.Api.Interfaces;
using ResumePro.Shared.Models;
using ResumePro.Shared.Options;

namespace ResumePro.IntegrationTests.Proxies;

public sealed class CompaniesProxy : BaseProxy, ICompaniesController
{
    public CompaniesProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public Task<List<CompanyDetails>> GetCompanies(int personId)
    {
        throw new NotImplementedException();
    }

    public Task<CompanyDetails> GetCompany(int personId, int companyId)
    {
        throw new NotImplementedException();
    }

    public Task<ActionResult<CompanyDetails>> CreateCompany(int personId, CompanyOptions options)
    {
        throw new NotImplementedException();
    }

    public Task<ActionResult<CompanyDetails>> UpdateCompany(int personId, int companyId, CompanyOptions options)
    {
        throw new NotImplementedException();
    }

    public Task<Result> DeleteCompany(int personId, int jobId)
    {
        throw new NotImplementedException();
    }
}