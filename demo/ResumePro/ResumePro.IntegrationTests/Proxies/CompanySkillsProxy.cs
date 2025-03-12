using Bespoke.IntegrationTesting.Bases;
using Bespoke.Shared.Common;
using ResumePro.Api.Interfaces;

namespace ResumePro.IntegrationTests.Proxies;

public sealed class CompanySkillsProxy : BaseProxy, ICompanySkillsController
{
    public CompanySkillsProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public Task<Result> AddCompanySkill(int personId, int companyId, int skillId)
    {
        throw new NotImplementedException();
    }

    public Task<Result> DeleteCompanySkill(int personId, int companyId, int skillId)
    {
        throw new NotImplementedException();
    }
}