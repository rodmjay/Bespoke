#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Bespoke.IntegrationTesting.Bases;
using Bespoke.Shared.Common;
using ResumePro.Api.Controllers;

namespace ResumePro.IntegrationTests.Proxies;

public sealed class CompanySkillsProxy : BaseProxy, ICompanySkillsController
{
    public CompanySkillsProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task<Result> AddCompanySkill(int personId, int companyId, int skillId)
    {
        throw new NotImplementedException();
    }

    public async Task<Result> DeleteCompanySkill(int personId, int companyId, int skillId)
    {
        throw new NotImplementedException();
    }
}