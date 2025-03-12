using NUnit.Framework;
using ResumePro.Shared.Models;
using Bespoke.IntegrationTesting.Extensions;

namespace ResumePro.IntegrationTests.Tests
{
    public abstract partial class BaseApiTest
    {
        protected async Task<List<PersonaLanguageDto>> AssertGetPersonLanguages(int personId)
        {
            var languages = await PersonLanguagesController.GetPersonLanguages(personId);
            Assert.That(languages, Is.Not.Null, "Failed to retrieve person languages");
            return languages;
        }
    }
}
