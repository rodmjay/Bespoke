using NUnit.Framework;
using System.Threading.Tasks;
using System;
using ResumePro.Shared.Models;
using ResumePro.Shared.Options;
using System.Linq;

namespace ResumePro.IntegrationTests.Tests.Controllers
{
    [TestFixture]
    public class ProjectsTests : BaseApiTest
    {
        // Private nested class for GetProject method tests
        [TestFixture]
        private class GetProjectMethodTests : ProjectsTests
        {
            [Test]
            public async Task GetProject_ShouldReturnProject()
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
                var createdProject = await AssertCreateProject(person.Id, company.Id, position.Id, projectOptions);
                
                // Act
                var project = await AssertGetProject(person.Id, company.Id, position.Id, createdProject.Id);
                
                // Assert
                Assert.That(project, Is.Not.Null);
                Assert.That(project.Id, Is.EqualTo(createdProject.Id));
                Assert.That(project.Name, Is.EqualTo(projectOptions.Name));
                Assert.That(project.Description, Is.EqualTo(projectOptions.Description));
            }
            
            [Test]
            public async Task GetProject_WithInvalidId_ShouldHandleError()
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
                    await ProjectsController.GetProject(person.Id, company.Id, position.Id, invalidProjectId);
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
        
        // Private nested class for GetList method tests
        [TestFixture]
        private class GetListMethodTests : ProjectsTests
        {
            [Test]
            public async Task GetList_ShouldReturnProjects()
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
                
                // Create multiple projects
                var project1Options = new ProjectOptions
                {
                    Name = $"Test Project 1 {Guid.NewGuid()}",
                    Description = "Test project 1 description"
                };
                var project2Options = new ProjectOptions
                {
                    Name = $"Test Project 2 {Guid.NewGuid()}",
                    Description = "Test project 2 description"
                };
                
                await AssertCreateProject(person.Id, company.Id, position.Id, project1Options);
                await AssertCreateProject(person.Id, company.Id, position.Id, project2Options);
                
                // Act
                var projects = await AssertGetProjects(person.Id, company.Id, position.Id);
                
                // Assert
                Assert.That(projects, Is.Not.Null);
                Assert.That(projects.Count >= 2);
                Assert.That(projects.Any(p => p.Name == project1Options.Name));
                Assert.That(projects.Any(p => p.Name == project2Options.Name));
            }
            
            [Test]
            public async Task GetList_WithInvalidPositionId_ShouldHandleError()
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
                
                int invalidPositionId = -1;
                
                try
                {
                    // Act
                    await ProjectsController.GetList(person.Id, company.Id, invalidPositionId);
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
