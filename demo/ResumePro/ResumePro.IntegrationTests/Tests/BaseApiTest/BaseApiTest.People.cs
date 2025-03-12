using NUnit.Framework;
using ResumePro.Shared.Models;
using ResumePro.Shared.Options;
using ResumePro.Shared.Filters;
using Bespoke.IntegrationTesting.Extensions;
using Bespoke.Shared.Common;
using Microsoft.AspNetCore.Mvc;

namespace ResumePro.IntegrationTests.Tests
{
    public abstract partial class BaseApiTest
    {
        protected async Task<PagedList<PersonaDto>> AssertGetPeople(PersonaFilters filters, PagingQuery paging)
        {
            var people = await PeopleController.GetPeople(filters, paging);
            Assert.That(people, Is.Not.Null, "Failed to retrieve people");
            Assert.That(people.Items, Is.Not.Null, "People items collection is null");
            return people;
        }

        protected async Task<PersonaDetails> AssertGetPerson(int personId)
        {
            var person = await PeopleController.GetPerson(personId);
            Assert.That(person, Is.Not.Null, "Failed to retrieve person");
            return person;
        }

        protected async Task<PersonaDetails> AssertCreatePerson(PersonOptions options)
        {
            var response = await PeopleController.CreatePerson(options);
            Assert.That(response.IsSuccessStatusCode(), "Person creation failed");
            var person = response.GetObject<PersonaDetails>();
            return person;
        }

        protected async Task<PersonaDetails> AssertUpdatePerson(int personId, PersonOptions options)
        {
            var response = await PeopleController.UpdatePerson(personId, options);
            Assert.That(response.IsSuccessStatusCode(), "Person update failed");
            var person = response.GetObject<PersonaDetails>();
            return person;
        }

        protected async Task<Result> AssertDeletePerson(int personId)
        {
            var result = await PeopleController.DeletePerson(personId);
            Assert.That(result.Succeeded, "Person deletion failed");
            return result;
        }
    }
}
