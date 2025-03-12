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
        protected async Task<PositionDetails> AssertGetPosition(int personId, int companyId, int positionId)
        {
            var position = await PositionsController.GetPosition(personId, companyId, positionId);
            Assert.That(position, Is.Not.Null, "Failed to retrieve position");
            return position;
        }

        protected async Task<List<PositionDetails>> AssertGetPositions(int personId, int companyId)
        {
            var positions = await PositionsController.GetPositions(personId, companyId);
            Assert.That(positions, Is.Not.Null, "Failed to retrieve positions");
            return positions;
        }

        protected async Task<CompanyDetails> AssertCreatePosition(int personId, int companyId, PositionOptions options)
        {
            var response = await PositionsController.CreatePosition(personId, companyId, options);
            Assert.That(response.IsSuccessStatusCode(), "Position creation failed");
            var company = response.GetObject<CompanyDetails>();
            return company;
        }

        protected async Task<CompanyDetails> AssertUpdatePosition(int personId, int companyId, int positionId, PositionOptions options)
        {
            var response = await PositionsController.UpdatePosition(personId, companyId, positionId, options);
            Assert.That(response.IsSuccessStatusCode(), "Position update failed");
            var company = response.GetObject<CompanyDetails>();
            return company;
        }

        protected async Task<Result> AssertDeletePosition(int personId, int companyId, int positionId)
        {
            var result = await PositionsController.DeletePosition(personId, companyId, positionId);
            Assert.That(result.Succeeded, "Position deletion failed");
            return result;
        }
    }
}
