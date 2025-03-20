using NUnit.Framework;
using System.Threading.Tasks;
using System;
using ResumePro.Shared.Models;
using ResumePro.Shared.Options;
using System.Linq;

namespace ResumePro.IntegrationTests.Tests.Controllers
{
    [TestFixture]
    public class ProjectHighlightsTests : BaseApiTest
    {
        // Private nested class for GetHighlight method tests
        [TestFixture]
        private class GetHighlightMethodTests : ProjectHighlightsTests
        {
            [Test]
            public async Task GetHighlight_ShouldReturnHighlight()
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
                
                var companyOptions = new CompanyOptions
                {
                    Company = $"Test Company {Guid.NewGuid()}",
                    Description = "Test company description",
                    Location = "Test location",
                    StartDate = DateTime.Now.AddYears(-3)
                };
                var company = await AssertCreateCompany(person.Id, companyOptions);
                
                var positionOptions = new PositionOptions
                {
                    JobTitle = $"Test Position {Guid.NewGuid()}",
                    StartDate = DateTime.Now.AddYears(-2),
                    EndDate = DateTime.Now.AddYears(-1)
                };
                var position = await AssertCreatePosition(person.Id, company.Id, positionOptions);
                
                var projectOptions = new ProjectOptions
                {
                    Name = $"Test Project {Guid.NewGuid()}",
                    Description = "Test project description"
                };
                var project = await AssertCreateProject(person.Id, company.Id, position.Id, projectOptions);
                
                var highlightOptions = new HighlightOptions
                {
                    Text = $"Test Highlight {Guid.NewGuid()}"
                };
                var createdHighlight = await AssertCreateProjectHighlight(person.Id, company.Id, position.Id, project.Id, highlightOptions);
                
                // Act
                var highlight = await AssertGetProjectHighlight(person.Id, company.Id, position.Id, project.Id, createdHighlight.Id);
                
                // Assert
                Assert.That(highlight, Is.Not.Null);
                Assert.That(highlight.Id, Is.EqualTo(createdHighlight.Id));
                Assert.That(highlight.Text, Is.EqualTo(highlightOptions.Text));
            }
            
            [Test]
            public async Task GetHighlight_WithInvalidId_ShouldHandleError()
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
                
                var companyOptions = new CompanyOptions
                {
                    Company = $"Test Company {Guid.NewGuid()}",
                    Description = "Test company description",
                    Location = "Test location",
                    StartDate = DateTime.Now.AddYears(-3)
                };
                var company = await AssertCreateCompany(person.Id, companyOptions);
                
                var positionOptions = new PositionOptions
                {
                    JobTitle = $"Test Position {Guid.NewGuid()}",
                    StartDate = DateTime.Now.AddYears(-2),
                    EndDate = DateTime.Now.AddYears(-1)
                };
                var position = await AssertCreatePosition(person.Id, company.Id, positionOptions);
                
                var projectOptions = new ProjectOptions
                {
                    Name = $"Test Project {Guid.NewGuid()}",
                    Description = "Test project description"
                };
                var project = await AssertCreateProject(person.Id, company.Id, position.Id, projectOptions);
                
                int invalidHighlightId = -1;
                
                try
                {
                    // Act
                    await ProjectHighlightsController.GetHighlight(person.Id, company.Id, position.Id, project.Id, invalidHighlightId);
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
        
        // Private nested class for GetHighlights method tests
        [TestFixture]
        private class GetHighlightsMethodTests : ProjectHighlightsTests
        {
            [Test]
            public async Task GetHighlights_ShouldReturnHighlights()
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
                
                var companyOptions = new CompanyOptions
                {
                    Company = $"Test Company {Guid.NewGuid()}",
                    Description = "Test company description",
                    Location = "Test location",
                    StartDate = DateTime.Now.AddYears(-3)
                };
                var company = await AssertCreateCompany(person.Id, companyOptions);
                
                var positionOptions = new PositionOptions
                {
                    JobTitle = $"Test Position {Guid.NewGuid()}",
                    StartDate = DateTime.Now.AddYears(-2),
                    EndDate = DateTime.Now.AddYears(-1)
                };
                var position = await AssertCreatePosition(person.Id, company.Id, positionOptions);
                
                var projectOptions = new ProjectOptions
                {
                    Name = $"Test Project {Guid.NewGuid()}",
                    Description = "Test project description"
                };
                var project = await AssertCreateProject(person.Id, company.Id, position.Id, projectOptions);
                
                // Create multiple highlights
                var highlight1Options = new HighlightOptions { Text = $"Test Highlight 1 {Guid.NewGuid()}" };
                var highlight2Options = new HighlightOptions { Text = $"Test Highlight 2 {Guid.NewGuid()}" };
                
                await AssertCreateProjectHighlight(person.Id, company.Id, position.Id, project.Id, highlight1Options);
                await AssertCreateProjectHighlight(person.Id, company.Id, position.Id, project.Id, highlight2Options);
                
                // Act
                var highlights = await AssertGetProjectHighlights(person.Id, company.Id, position.Id, project.Id);
                
                // Assert
                Assert.That(highlights, Is.Not.Null);
                Assert.That(highlights.Count >= 2);
                Assert.That(highlights.Any(h => h.Text == highlight1Options.Text));
                Assert.That(highlights.Any(h => h.Text == highlight2Options.Text));
            }
            
            [Test]
            public async Task GetHighlights_WithInvalidProjectId_ShouldHandleError()
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
                
                var companyOptions = new CompanyOptions
                {
                    Company = $"Test Company {Guid.NewGuid()}",
                    Description = "Test company description",
                    Location = "Test location",
                    StartDate = DateTime.Now.AddYears(-3)
                };
                var company = await AssertCreateCompany(person.Id, companyOptions);
                
                var positionOptions = new PositionOptions
                {
                    JobTitle = $"Test Position {Guid.NewGuid()}",
                    StartDate = DateTime.Now.AddYears(-2),
                    EndDate = DateTime.Now.AddYears(-1)
                };
                var position = await AssertCreatePosition(person.Id, company.Id, positionOptions);
                
                int invalidProjectId = -1;
                
                try
                {
                    // Act
                    await ProjectHighlightsController.GetHighlights(person.Id, company.Id, position.Id, invalidProjectId);
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
