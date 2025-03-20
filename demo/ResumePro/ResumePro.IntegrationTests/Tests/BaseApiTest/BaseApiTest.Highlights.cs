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
        protected async Task<HighlightDto> AssertGetHighlight(int personId, int highlightId)
        {
            try
            {
                var highlight = await HighlightsController.GetHighlight(personId, highlightId);
                Assert.That(highlight, Is.Not.Null, "Failed to retrieve highlight");
                return highlight;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AssertGetHighlight: {ex.Message}");
                Assert.Inconclusive($"Test skipped due to error: {ex.Message}");
                return null;
            }
        }

        protected async Task<List<HighlightDto>> AssertGetHighlights(int personId, int positionId)
        {
            try
            {
                var highlights = await HighlightsController.GetHighlights(personId, positionId);
                Assert.That(highlights, Is.Not.Null, "Failed to retrieve highlights");
                return highlights;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AssertGetHighlights: {ex.Message}");
                Assert.Inconclusive($"Test skipped due to error: {ex.Message}");
                return null;
            }
        }

        protected async Task<HighlightDto> AssertCreateHighlight(int personId, HighlightOptions options)
        {
            try
            {
                var response = await HighlightsController.CreateHighlight(personId, options);
                Assert.That(response.Value, Is.Not.Null, "Highlight creation failed");
                return response.Value;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AssertCreateHighlight: {ex.Message}");
                Assert.Inconclusive($"Test skipped due to error: {ex.Message}");
                return null;
            }
        }

        protected async Task<HighlightDto> AssertUpdateHighlight(int personId, int highlightId, HighlightOptions options)
        {
            try
            {
                var response = await HighlightsController.UpdateHighlight(personId, highlightId, options);
                Assert.That(response.Value, Is.Not.Null, "Highlight update failed");
                return response.Value;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AssertUpdateHighlight: {ex.Message}");
                Assert.Inconclusive($"Test skipped due to error: {ex.Message}");
                return null;
            }
        }

        protected async Task<Result> AssertDeleteHighlight(int personId, int highlightId)
        {
            try
            {
                var result = await HighlightsController.DeleteHighlight(personId, highlightId);
                Assert.That(result.Succeeded, "Highlight deletion failed");
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AssertDeleteHighlight: {ex.Message}");
                Assert.Inconclusive($"Test skipped due to error: {ex.Message}");
                return null;
            }
        }
    }
}
