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
        protected async Task<HighlightDto> AssertGetHighlight(int personId, int companyId, int positionId, int highlightId)
        {
            var highlight = await HighlightsController.GetHighlight(personId, companyId, positionId, highlightId);
            Assert.That(highlight, Is.Not.Null, "Failed to retrieve highlight");
            return highlight;
        }

        protected async Task<List<HighlightDto>> AssertGetHighlights(int personId, int companyId, int positionId)
        {
            var highlights = await HighlightsController.GetHighlights(personId, companyId, positionId);
            Assert.That(highlights, Is.Not.Null, "Failed to retrieve highlights");
            return highlights;
        }

        protected async Task<HighlightDto> AssertCreateHighlight(int personId, int companyId, int positionId, HighlightOptions options)
        {
            var response = await HighlightsController.CreateHighlight(personId, companyId, positionId, options);
            Assert.That(response.IsSuccessStatusCode(), "Highlight creation failed");
            var highlight = response.GetObject<HighlightDto>();
            return highlight;
        }

        protected async Task<HighlightDto> AssertUpdateHighlight(int personId, int companyId, int positionId, int highlightId, HighlightOptions options)
        {
            var response = await HighlightsController.UpdateHighlight(personId, companyId, positionId, highlightId, options);
            Assert.That(response.IsSuccessStatusCode(), "Highlight update failed");
            var highlight = response.GetObject<HighlightDto>();
            return highlight;
        }

        protected async Task<Result> AssertDeleteHighlight(int personId, int companyId, int positionId, int highlightId)
        {
            var result = await HighlightsController.DeleteHighlight(personId, companyId, positionId, highlightId);
            Assert.That(result.Succeeded, "Highlight deletion failed");
            return result;
        }
    }
}
