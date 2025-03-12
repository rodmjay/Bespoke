namespace ResumePro.Shared.Models;

public class LanguageDto : ILanguage
{
    public string Name { get; set; } = null!;
    public string Code2 { get; set; } = null!;
    public string Code3 { get; set; } = null!;
}