using Bespoke.IntegrationTesting.Bases;
using Bespoke.Shared.Common;
using ResumePro.Api.Interfaces;
using ResumePro.Shared.Models;

namespace ResumePro.IntegrationTests.Proxies;

public sealed class PersonSkillsProxy : BaseProxy, IPersonSkillsController
{
    public PersonSkillsProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public Task<List<PersonaSkillDto>> GetSkills(int personId)
    {
        throw new NotImplementedException();
    }

    public Task<Result> ToggleSkill(int personId, int skillId)
    {
        throw new NotImplementedException();
    }
}