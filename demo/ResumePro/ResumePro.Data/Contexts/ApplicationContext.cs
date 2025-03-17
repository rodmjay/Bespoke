using System.Diagnostics.CodeAnalysis;
using Bespoke.Data;
using Bespoke.Data.Attributes;
using Bespoke.Data.Bases;
using Bespoke.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ResumePro.Domain.Entities;
using ResumePro.Entities;

[assembly: SeedAssembly]

namespace ResumePro.Data.Contexts;

[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
public sealed class ApplicationContext : BaseContext<ApplicationContext>
{
    public ApplicationContext(
        DbContextOptions<ApplicationContext> options, IOptions<DbSettings> settings) : base(options, settings)
    {
    }

    protected override void SeedDatabase(ModelBuilder builder)
    {
        // these should be placed in the Seeding/csv folder for it to work
        // make sure files are marked as "EmbeddedResource => Copy if newer"
        builder.Entity<Country>().Seed("countries.csv");
        builder.Entity<StateProvince>().Seed("state_provinces.csv");
        builder.Entity<Skill>().Seed("skills.csv");
        builder.Entity<Language>().Seed("languages.csv");
        builder.Entity<Persona>().Seed("personas.csv");
        
        builder.Entity<Template>().Seed("templates.csv");
        builder.Entity<School>().Seed("schools.csv");
        builder.Entity<Degree>().Seed("degrees.csv");
        builder.Entity<SkillCategory>().Seed("skill_categories.csv");
        builder.Entity<SkillCategorySkill>().Seed("category_skills.csv");
        
        builder.Entity<Company>().Seed("companies.csv");
        builder.Entity<Position>().Seed("positions.csv");
        builder.Entity<Project>().Seed("projects.csv");
        builder.Entity<ProjectHighlight>().Seed("project_highlights.csv");
        builder.Entity<Highlight>().Seed("highlights.csv");
        
        builder.Entity<PersonaSkill>().Seed("persona_skills.csv");
        builder.Entity<PersonaLanguage>().Seed("persona_language.csv");
        builder.Entity<CompanySkill>().Seed("company_skills.csv");
        
        builder.Entity<Resume>().Seed("resumes.csv");
        builder.Entity<ResumeSettings>().Seed("resume_settings.csv");
        builder.Entity<OrganizationSettings>().Seed("organization_settings.csv");
        builder.Entity<ResumeSkill>().Seed("resume_skills.csv");
        builder.Entity<ResumeCompany>().Seed("resume_companies.csv");
        builder.Entity<Reference>().Seed("references.csv");
    }

    protected override void PreModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(typeof(Resume).Assembly);
    }
}
