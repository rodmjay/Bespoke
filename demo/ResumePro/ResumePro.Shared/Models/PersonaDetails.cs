#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

namespace ResumePro.Shared.Models;

public class PersonaDetails : PersonaDto
{
    public List<ResumeDto> Resumes { get; set; } = new List<ResumeDto>();
    public List<PersonaSkillDto> Skills { get; set; } = new List<PersonaSkillDto>();    
    public List<CompanyDetails> Jobs { get; set; } = new List<CompanyDetails>();
    public List<SchoolDetails> Education { get; set; } = new List<SchoolDetails>();
    public List<PersonaLanguageDto> Languages { get; set; } = new List<PersonaLanguageDto>();
    public List<CertificationDto> Certifications { get; set; } = new List<CertificationDto>();
    public List<ReferenceDto> References { get; set; } = new List<ReferenceDto>();
}