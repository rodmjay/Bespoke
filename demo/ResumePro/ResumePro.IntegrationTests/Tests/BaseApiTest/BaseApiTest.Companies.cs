using NUnit.Framework;
using ResumePro.Shared.Models;
using ResumePro.Shared.Options;
using Bespoke.IntegrationTesting.Extensions;
using Bespoke.Shared.Common;
using Microsoft.AspNetCore.Mvc;

namespace ResumePro.IntegrationTests.Tests
{
    public abstract partial class BaseApiTest
    {
        protected async Task<CompanyDetails> AssertGetCompany(int personId, int companyId)
        {
            var company = await CompaniesController.GetCompany(personId, companyId);
            Assert.That(company, Is.Not.Null, "Failed to retrieve company");
            return company;
        }

        protected async Task<List<CompanyDetails>> AssertGetCompanies(int personId)
        {
            var companies = await CompaniesController.GetCompanies(personId);
            Assert.That(companies, Is.Not.Null, "Failed to retrieve companies");
            return companies;
        }

        protected async Task<CompanyDetails> AssertCreateCompany(int personId, CompanyOptions options)
        {
            var response = await CompaniesController.CreateCompany(personId, options);
            Assert.That(response.IsSuccessStatusCode(), "Company creation failed");
            var company = response.GetObject<CompanyDetails>();
            return company;
        }

        protected async Task<CompanyDetails> AssertUpdateCompany(int personId, int companyId, CompanyOptions options)
        {
            var response = await CompaniesController.UpdateCompany(personId, companyId, options);
            Assert.That(response.IsSuccessStatusCode(), "Company update failed");
            var company = response.GetObject<CompanyDetails>();
            return company;
        }

        protected async Task<Result> AssertDeleteCompany(int personId, int companyId)
        {
            var result = await CompaniesController.DeleteCompany(personId, companyId);
            Assert.That(result.Succeeded, "Company deletion failed");
            return result;
        }
    }
}
