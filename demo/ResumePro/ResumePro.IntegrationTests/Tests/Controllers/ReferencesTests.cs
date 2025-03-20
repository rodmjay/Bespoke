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
                var personOptions = new PersonOptions
                {
                    Email = $"test-{Guid.NewGuid()}@example.com",
                    FirstName = "Test",
                    LastName = "User",
                    City = "Test City",
                    PhoneNumber = "555-123-4567"
                };
                var person = await AssertCreatePerson(personOptions);
                
                var referenceOptions = new ReferenceOptions
                {
                    Name = $"Test Reference {Guid.NewGuid()}",
                    Text = "This is a reference description",
                    Order = 1
                };
                var createdReference = await AssertCreateReference(person.Id, referenceOptions);
                
                // Act
                var reference = await AssertGetReference(person.Id, createdReference.Id);
                
                // Assert
                Assert.That(reference, Is.Not.Null);
                Assert.That(reference.Id, Is.EqualTo(createdReference.Id));
                Assert.That(reference.Name, Is.EqualTo(referenceOptions.Name));
                Assert.That(reference.Text, Is.EqualTo(referenceOptions.Text));
                Assert.That(reference.Order, Is.EqualTo(referenceOptions.Order));
            }
            
            [Test]
            public async Task Get_WithInvalidId_ShouldHandleError()
            {
                // Arrange
                var personOptions = new PersonOptions
                {
                    Email = $"test-{Guid.NewGuid()}@example.com",
                    FirstName = "Test",
                    LastName = "User",
                    City = "Test City",
                    PhoneNumber = "555-123-4567"
                };
                var person = await AssertCreatePerson(personOptions);
                
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
                var personOptions = new PersonOptions
                {
                    Email = $"test-{Guid.NewGuid()}@example.com",
                    FirstName = "Test",
                    LastName = "User",
                    City = "Test City",
                    PhoneNumber = "555-123-4567"
                };
                var person = await AssertCreatePerson(personOptions);
                
                // Create multiple references
                var reference1Options = new ReferenceOptions
                {
                    Name = $"Test Reference 1 {Guid.NewGuid()}",
                    Text = "This is reference 1 description",
                    Order = 1
                };
                var reference2Options = new ReferenceOptions
                {
                    Name = $"Test Reference 2 {Guid.NewGuid()}",
                    Text = "This is reference 2 description",
                    Order = 2
                };
                
                await AssertCreateReference(person.Id, reference1Options);
                await AssertCreateReference(person.Id, reference2Options);
                
                // Act
                var references = await AssertGetReferences(person.Id);
                
                // Assert
                Assert.That(references, Is.Not.Null);
                Assert.That(references.Count >= 2);
                Assert.That(references.Any(r => r.Name == reference1Options.Name));
                Assert.That(references.Any(r => r.Name == reference2Options.Name));
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
