﻿#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using System.Diagnostics.CodeAnalysis;
using Bespoke.Data.Enums;
using Bespoke.Data.Extensions;
using Bespoke.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ResumePro.Services.ErrorDescribers;
using ResumePro.Services.Interfaces;
using ResumePro.Shared.Models;
using ResumePro.Shared.Options;

namespace ResumePro.Services.Implementations;

[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
public sealed class PersonaLanguageService : BaseService<PersonaLanguage>, IPersonaLanguageService
{
    private readonly LanguageErrorDescriber _languageErrors;
    private readonly IRepositoryAsync<Language> _languageRepo;

    public PersonaLanguageService(IServiceProvider serviceProvider,
        LanguageErrorDescriber languageErrors,
        IRepositoryAsync<Language> languageRepo) : base(serviceProvider)
    {
        _languageErrors = languageErrors;
        _languageRepo = languageRepo;
    }

    private IQueryable<PersonaLanguage> PersonaLanguages => Repository.Queryable();
    private IQueryable<Language> Languages => _languageRepo.Queryable();

    public Task<T> GetPersonaLanguage<T>(int organizationId, int personId, string language) where T : PersonaLanguageDto
    {
        return PersonaLanguages.AsNoTracking()
            .Where(x => x.OrganizationId == organizationId && x.PersonId == personId)
            .ProjectTo<T>(Mapper)
            .FirstOrDefaultAsync();
    }

    public Task<List<T>> GetPersonaLanguages<T>(int organizationId, int personId) where T : PersonaLanguageDto
    {
        return PersonaLanguages.AsNoTracking()
            .Where(x => x.OrganizationId == organizationId && x.PersonId == personId)
            .ProjectTo<T>(Mapper)
            .ToListAsync();
    }

    public async Task<OneOf<PersonaLanguageDto, Result>> CreateOrUpdatePersonaLanguage(int organizationId, int personId,
        PersonLanguageOptions options)
    {
        Logger.LogInformation(
            GetLogMessage("OrganizationId: {@organizationId}, PersonId: {@personId}, Options: {@options}"));

        var errors = new List<Error>();

        await foreach (var error in GetErrors(options.LanguageId)) errors.Add(error);

        if (errors.Any())
            return Result.Failed(errors.ToArray());

        var pl = await PersonaLanguages.Where(x =>
                x.OrganizationId == organizationId && x.PersonId == personId && x.Code3 == options.LanguageId)
            .FirstOrDefaultAsync();

        if (pl == null)
            pl = new PersonaLanguage
            {
                ObjectState = ObjectState.Added,
                PersonId = personId,
                OrganizationId = organizationId
            };
        else
            pl.ObjectState = ObjectState.Modified;

        pl.Code3 = options.LanguageId;
        pl.Proficiency = options.Proficiency;

        var records = Repository.InsertOrUpdateGraph(pl, true);
        if (records > 0)
            return await GetPersonaLanguage<PersonaLanguageDto>(organizationId, personId, options.LanguageId);

        return Result.Failed();
    }

    private async IAsyncEnumerable<Error> GetErrors(string language)
    {
        var languageExists = await Languages
            .AsNoTracking()
            .Where(x => x.Code3 == language).AnyAsync();

        if (!languageExists)
            yield return _languageErrors.LanguageNotFound(language);
    }
}