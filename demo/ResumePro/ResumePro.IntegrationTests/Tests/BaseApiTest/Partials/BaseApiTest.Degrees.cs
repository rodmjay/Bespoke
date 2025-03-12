using NUnit.Framework;
using ResumePro.Shared.Models;
using ResumePro.Shared.Options;
using Bespoke.IntegrationTesting.Extensions;
using Bespoke.Shared.Common;
using Microsoft.AspNetCore.Mvc;

namespace ResumePro.IntegrationTests.Tests
{
    public abstract partial class BaseApiTest
    {
        protected async Task<DegreeDto> AssertGetDegree(int personId, int schoolId, int degreeId)
        {
            var degree = await DegreesController.GetDegree(personId, schoolId, degreeId);
            Assert.That(degree, Is.Not.Null, "Failed to retrieve degree");
            return degree;
        }

        protected async Task<List<DegreeDto>> AssertGetDegrees(int personId, int schoolId)
        {
            var degrees = await DegreesController.GetDegrees(personId, schoolId);
            Assert.That(degrees, Is.Not.Null, "Failed to retrieve degrees");
            return degrees;
        }

        protected async Task<DegreeDto> AssertCreateDegree(int personId, int schoolId, DegreeOptions options)
        {
            var response = await DegreesController.CreateDegree(personId, schoolId, options);
            Assert.That(response.IsSuccessStatusCode(), "Degree creation failed");
            var degree = response.GetObject<DegreeDto>();
            return degree;
        }

        protected async Task<DegreeDto> AssertUpdateDegree(int personId, int schoolId, int degreeId, DegreeOptions options)
        {
            var response = await DegreesController.UpdateDegree(personId, schoolId, degreeId, options);
            Assert.That(response.IsSuccessStatusCode(), "Degree update failed");
            var degree = response.GetObject<DegreeDto>();
            return degree;
        }

        protected async Task<Result> AssertDeleteDegree(int personId, int schoolId, int degreeId)
        {
            var result = await DegreesController.DeleteDegree(personId, schoolId, degreeId);
            Assert.That(result.Succeeded, "Degree deletion failed");
            return result;
        }
    }
}
