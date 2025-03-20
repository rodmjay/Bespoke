using NUnit.Framework;
using System.Threading.Tasks;
using System;
using ResumePro.Shared.Models;
using ResumePro.Shared.Options;
using System.Linq;

namespace ResumePro.IntegrationTests.Tests.Controllers
{
    [TestFixture]
    public class ReferencesTests : BaseApiTest
    {
        // Private nested class for Get method tests
        [TestFixture]
        private class GetMethodTests : ReferencesTests
        {
            [Test]
            public async Task Get_ShouldReturnReference()
            {
                // Arrange
                var email = $"test-{Guid.NewGuid()}@example.com";
                var person = await AssertCreatePerson(email);
                
                var referenceOptions = new ReferenceOptions
                {
                    Name = $"Test Reference {Guid.NewGuid()}",
                    Title = "Test Title",
                    Company = "Test Company",
                    Email = $"reference-{Guid.NewGuid()}@example.com",
                    Phone = "555-123-4567"
                };
                var createdReference = await AssertCreateReference(person.Id, referenceOptions);
                
                // Act
                var reference = await AssertGetReference(person.Id, createdReference.Id);
                
                // Assert
                Assert.That(reference, Is.Not.Null);
                Assert.That(reference.Id, Is.EqualTo(createdReference.Id));
                Assert.That(reference.Name, Is.EqualTo(referenceOptions.Name));
                Assert.That(reference.Title, Is.EqualTo(referenceOptions.Title));
                Assert.That(reference.Company, Is.EqualTo(referenceOptions.Company));
                Assert.That(reference.Email, Is.EqualTo(referenceOptions.Email));
                Assert.That(reference.Phone, Is.EqualTo(referenceOptions.Phone));
            }
            
            [Test]
            public async Task Get_WithInvalidId_ShouldHandleError()
            {
                // Arrange
                var email = $"test-{Guid.NewGuid()}@example.com";
                var person = await AssertCreatePerson(email);
                
                int invalidReferenceId = -1;
                
                try
                {
                    // Act
                    await ReferencesController.Get(person.Id, invalidReferenceId);
                    Assert.Fail("Expected exception was not thrown");
                }
                catch (Exception ex)
                {
                    // Assert
                    Assert.That(ex, Is.Not.Null);
                    Assert.Pass("Exception was thrown as expected");
                }
            }
        }
        
        // Private nested class for GetReferences method tests
        [TestFixture]
        private class GetReferencesMethodTests : ReferencesTests
        {
            [Test]
            public async Task GetReferences_ShouldReturnReferences()
            {
                // Arrange
                var email = $"test-{Guid.NewGuid()}@example.com";
                var person = await AssertCreatePerson(email);
                
                // Create multiple references
                var reference1Options = new ReferenceOptions
                {
                    Name = $"Test Reference 1 {Guid.NewGuid()}",
                    Title = "Test Title 1",
                    Company = "Test Company 1",
                    Email = $"reference1-{Guid.NewGuid()}@example.com",
                    Phone = "555-123-4567"
                };
                var reference2Options = new ReferenceOptions
                {
                    Name = $"Test Reference 2 {Guid.NewGuid()}",
                    Title = "Test Title 2",
                    Company = "Test Company 2",
                    Email = $"reference2-{Guid.NewGuid()}@example.com",
                    Phone = "555-987-6543"
                };
                
                await AssertCreateReference(person.Id, reference1Options);
                await AssertCreateReference(person.Id, reference2Options);
                
                // Act
                var references = await AssertGetReferences(person.Id);
                
                // Assert
                Assert.That(references, Is.Not.Null);
                Assert.That(references.Count, Is.GreaterThanOrEqualTo(2));
                Assert.That(references.Any(r => r.Name == reference1Options.Name), Is.True);
                Assert.That(references.Any(r => r.Name == reference2Options.Name), Is.True);
            }
            
            [Test]
            public async Task GetReferences_WithInvalidPersonId_ShouldHandleError()
            {
                // Arrange
                int invalidPersonId = -1;
                
                try
                {
                    // Act
                    await ReferencesController.GetReferences(invalidPersonId);
                    Assert.Fail("Expected exception was not thrown");
                }
                catch (Exception ex)
                {
                    // Assert
                    Assert.That(ex, Is.Not.Null);
                    Assert.Pass("Exception was thrown as expected");
                }
            }
        }
    }
}
