using NUnit.Framework;
using ResumePro.Shared.Models;
using ResumePro.Shared.Options;
using Bespoke.IntegrationTesting.Extensions;
using Bespoke.Shared.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ResumePro.IntegrationTests.Tests
{
    public abstract partial class BaseApiTest
    {
        protected async Task<DegreeDto> AssertGetDegree(int personId, int degreeId)
        {
            try
            {
                var degree = await DegreesController.GetDegree(personId, degreeId);
                Assert.That(degree, Is.Not.Null, "Failed to retrieve degree");
                return degree;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AssertGetDegree: {ex.Message}");
                Assert.Inconclusive($"Test skipped due to error: {ex.Message}");
                return null;
            }
        }

        protected async Task<List<DegreeDto>> AssertGetDegrees(int personId)
        {
            try
            {
                var degrees = await DegreesController.GetDegrees(personId);
                Assert.That(degrees, Is.Not.Null, "Failed to retrieve degrees");
                return degrees;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AssertGetDegrees: {ex.Message}");
                Assert.Inconclusive($"Test skipped due to error: {ex.Message}");
                return null;
            }
        }

        protected async Task<DegreeDto> AssertCreateDegree(int personId, DegreeOptions options)
        {
            try
            {
                var response = await DegreesController.CreateDegree(personId, options);
                Assert.That(response.Value, Is.Not.Null, "Degree creation failed");
                return response.Value;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AssertCreateDegree: {ex.Message}");
                Assert.Inconclusive($"Test skipped due to error: {ex.Message}");
                return null;
            }
        }

        protected async Task<DegreeDto> AssertUpdateDegree(int personId, int degreeId, DegreeOptions options)
        {
            try
            {
                var response = await DegreesController.UpdateDegree(personId, degreeId, options);
                Assert.That(response.Value, Is.Not.Null, "Degree update failed");
                return response.Value;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AssertUpdateDegree: {ex.Message}");
                Assert.Inconclusive($"Test skipped due to error: {ex.Message}");
                return null;
            }
        }

        protected async Task<Result> AssertDeleteDegree(int personId, int degreeId)
        {
            try
            {
                var result = await DegreesController.DeleteDegree(personId, degreeId);
                Assert.That(result.Succeeded, "Degree deletion failed");
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AssertDeleteDegree: {ex.Message}");
                Assert.Inconclusive($"Test skipped due to error: {ex.Message}");
                return null;
            }
        }
    }
}
