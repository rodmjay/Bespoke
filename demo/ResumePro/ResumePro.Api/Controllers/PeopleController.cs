﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using ResumePro.Api.Interfaces;
using ResumePro.Services.Interfaces;
using ResumePro.Shared.Filters;

namespace ResumePro.Api.Controllers;

public sealed class PeopleController : BaseController, IPeopleController
{
    private readonly IPeopleService _peopleService;

    public PeopleController(IServiceProvider serviceProvider, IPeopleService peopleService) : base(serviceProvider)
    {
        _peopleService = peopleService;
    }

    [HttpPost("Search")]
    public async Task<PagedList<PersonaDto>> GetPeople(
        [FromBody(EmptyBodyBehavior = EmptyBodyBehavior.Allow)]
        PersonaFilters? filters, [FromQuery] PagingQuery paging)
    {
        filters ??= new PersonaFilters();
        return await _peopleService.GetPeople<PersonaDto>(OrganizationId, filters, paging)
            .ConfigureAwait(false);
    }

    [HttpGet("{personId}")]
    public async Task<PersonaDetails> GetPerson([FromRoute] int personId)
    {
        return await _peopleService.GetPerson<PersonaDetails>(OrganizationId, personId)
            .ConfigureAwait(false);
    }

    [HttpPost]
    public async Task<ActionResult<PersonaDetails>> CreatePerson([FromBody] PersonOptions options)
    {
        var result = await _peopleService.CreatePerson(OrganizationId, options)
            .ConfigureAwait(false);
        if (result.IsT0)
            return Ok(result.AsT0);

        return BadRequest(result.AsT1);
    }

    [HttpPut("{personId}")]
    public async Task<ActionResult<PersonaDetails>> UpdatePerson([FromRoute] int personId,
        [FromBody] PersonOptions options)
    {
        var result = await _peopleService.UpdatePerson(OrganizationId, personId, options)
            .ConfigureAwait(false);
        if (result.IsT0)
            return Ok(result.AsT0);

        return BadRequest(result.AsT1);
    }

    [HttpDelete("{personId}")]
    public async Task<Result> DeletePerson([FromRoute] int personId)
    {
        return await _peopleService.DeletePerson(OrganizationId, personId)
            .ConfigureAwait(false);
    }
}