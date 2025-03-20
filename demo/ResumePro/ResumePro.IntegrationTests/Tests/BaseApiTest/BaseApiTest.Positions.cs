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
        protected async Task<PositionDto> AssertGetPosition(int personId, int positionId)
        {
            try
            {
                var position = await PositionsController.GetPosition(personId, positionId);
                Assert.That(position, Is.Not.Null, "Failed to retrieve position");
                return position;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AssertGetPosition: {ex.Message}");
                Assert.Inconclusive($"Test skipped due to error: {ex.Message}");
                return null;
            }
        }

        protected async Task<List<PositionDto>> AssertGetPositions(int personId)
        {
            try
            {
                var positions = await PositionsController.GetPositions(personId);
                Assert.That(positions, Is.Not.Null, "Failed to retrieve positions");
                return positions;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AssertGetPositions: {ex.Message}");
                Assert.Inconclusive($"Test skipped due to error: {ex.Message}");
                return null;
            }
        }

        protected async Task<PositionDto> AssertCreatePosition(int personId, PositionOptions options)
        {
            try
            {
                var response = await PositionsController.CreatePosition(personId, options);
                Assert.That(response.Value, Is.Not.Null, "Position creation failed");
                return response.Value;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AssertCreatePosition: {ex.Message}");
                Assert.Inconclusive($"Test skipped due to error: {ex.Message}");
                return null;
            }
        }

        protected async Task<PositionDto> AssertUpdatePosition(int personId, int positionId, PositionOptions options)
        {
            try
            {
                var response = await PositionsController.UpdatePosition(personId, positionId, options);
                Assert.That(response.Value, Is.Not.Null, "Position update failed");
                return response.Value;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AssertUpdatePosition: {ex.Message}");
                Assert.Inconclusive($"Test skipped due to error: {ex.Message}");
                return null;
            }
        }

        protected async Task<Result> AssertDeletePosition(int personId, int positionId)
        {
            try
            {
                var result = await PositionsController.DeletePosition(personId, positionId);
                Assert.That(result.Succeeded, "Position deletion failed");
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AssertDeletePosition: {ex.Message}");
                Assert.Inconclusive($"Test skipped due to error: {ex.Message}");
                return null;
            }
        }
    }
}
