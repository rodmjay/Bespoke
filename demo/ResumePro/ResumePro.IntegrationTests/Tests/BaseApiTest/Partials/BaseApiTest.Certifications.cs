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
        protected async Task<CertificationDto> AssertGetCertification(int personId, int certificationId)
        {
            var certification = await CertificationsController.Get(personId, certificationId);
            Assert.That(certification, Is.Not.Null, "Failed to retrieve certification");
            return certification;
        }

        protected async Task<List<CertificationDto>> AssertGetCertifications(int personId)
        {
            var certifications = await CertificationsController.Get(personId);
            Assert.That(certifications, Is.Not.Null, "Failed to retrieve certifications");
            return certifications;
        }

        protected async Task<CertificationDto> AssertCreateCertification(int personId, CertificationOptions options)
        {
            var response = await CertificationsController.CreateCertification(personId, options);
            Assert.That(response.IsSuccessStatusCode(), "Certification creation failed");
            var certification = response.GetObject<CertificationDto>();
            return certification;
        }

        protected async Task<CertificationDto> AssertUpdateCertification(int personId, int certificationId, CertificationOptions options)
        {
            var response = await CertificationsController.Update(personId, certificationId, options);
            Assert.That(response.IsSuccessStatusCode(), "Certification update failed");
            var certification = response.GetObject<CertificationDto>();
            return certification;
        }

        protected async Task<Result> AssertDeleteCertification(int personId, int certificationId)
        {
            var result = await CertificationsController.Delete(personId, certificationId);
            Assert.That(result.Succeeded, "Certification deletion failed");
            return result;
        }
    }
}
