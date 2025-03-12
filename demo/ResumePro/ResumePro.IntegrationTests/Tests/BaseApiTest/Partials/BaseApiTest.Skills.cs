using NUnit.Framework;
using ResumePro.Shared.Models;
using Bespoke.IntegrationTesting.Extensions;

namespace ResumePro.IntegrationTests.Tests
{
    public abstract partial class BaseApiTest
    {
        protected async Task<List<SkillDto>> AssertGetSkills()
        {
            var skills = await SkillsController.GetSkills();
            Assert.That(skills, Is.Not.Null, "Failed to retrieve skills");
            return skills;
        }
    }
}
