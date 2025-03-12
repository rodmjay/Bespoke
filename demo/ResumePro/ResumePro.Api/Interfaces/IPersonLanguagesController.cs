namespace ResumePro.Api.Interfaces;

public interface IPersonLanguagesController
{
    Task<List<PersonaLanguageDto>> GetPersonLanguages(int personId);
}