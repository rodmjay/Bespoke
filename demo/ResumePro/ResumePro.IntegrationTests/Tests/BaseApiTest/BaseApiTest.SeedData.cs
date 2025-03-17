using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ResumePro.Data.Contexts;
using ResumePro.Domain.Entities;

namespace ResumePro.IntegrationTests.Tests
{
    public abstract partial class BaseApiTest
    {
        protected async Task<List<Skill>> GetSeededSkills()
        {
            using var scope = ServiceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
            return await context.Set<Skill>().ToListAsync();
        }
        
        protected async Task<List<School>> GetSeededSchools()
        {
            using var scope = ServiceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
            return await context.Set<School>().ToListAsync();
        }
        
        protected async Task<List<Degree>> GetSeededDegrees()
        {
            using var scope = ServiceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
            return await context.Set<Degree>().ToListAsync();
        }
        
        protected async Task<List<Persona>> GetSeededPersonas()
        {
            using var scope = ServiceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
            return await context.Set<Persona>().ToListAsync();
        }
        
        protected async Task<List<PersonaSkill>> GetSeededPersonaSkills()
        {
            using var scope = ServiceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
            return await context.Set<PersonaSkill>().ToListAsync();
        }
        
        protected async Task<List<PersonaLanguage>> GetSeededPersonaLanguages()
        {
            using var scope = ServiceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
            return await context.Set<PersonaLanguage>().ToListAsync();
        }
        
        protected async Task<List<Language>> GetSeededLanguages()
        {
            using var scope = ServiceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
            return await context.Set<Language>().ToListAsync();
        }
        
        protected async Task<List<StateProvince>> GetSeededStateProvinces()
        {
            using var scope = ServiceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
            return await context.Set<StateProvince>().ToListAsync();
        }
        
        protected async Task<List<Country>> GetSeededCountries()
        {
            using var scope = ServiceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
            return await context.Set<Country>().ToListAsync();
        }
    }
}
