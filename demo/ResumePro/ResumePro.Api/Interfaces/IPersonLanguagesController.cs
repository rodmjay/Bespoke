using Bespoke.Shared.Common;
using ResumePro.Shared.Models;

namespace ResumePro.Api.Interfaces;

public interface IPersonLanguagesController
{
    Task<List<PersonaLanguageDto>> GetPersonLanguages(int personId);
    Task<Result> ToggleLanguage(int personId, int languageId, string proficiency);
}
