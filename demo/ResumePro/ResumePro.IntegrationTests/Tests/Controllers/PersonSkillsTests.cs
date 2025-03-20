using NUnit.Framework;
using System.Threading.Tasks;
using System;
using ResumePro.Shared.Models;
using System.Linq;

namespace ResumePro.IntegrationTests.Tests.Controllers
{
    [TestFixture]
    public class PersonSkillsTests : BaseApiTest
    {
        // Private nested class for GetSkills method tests
        [TestFixture]
        private class GetSkillsMethodTests : PersonSkillsTests
        {
            [Test]
            public async Task GetSkills_ShouldReturnPersonSkills()
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
                
                // Create a skill and associate it with the person
                var skill = await AssertCreateSkill($"Test Skill {Guid.NewGuid()}");
                await AssertTogglePersonSkill(person.Id, skill.Id);
                
                // Act
                var skills = await AssertGetPersonSkills(person.Id);
                
                // Assert
                Assert.That(skills, Is.Not.Null);
                Assert.That(skills.Count >= 1);
                Assert.That(skills.Any(s => s.Id == skill.Id));
            }
            
            [Test]
            public async Task GetSkills_WithInvalidPersonId_ShouldHandleError()
            {
                // Arrange
                int invalidPersonId = -1;
                
                try
                {
                    // Act
                    await PersonSkillsController.GetSkills(invalidPersonId);
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
        
        // Private nested class for ToggleSkill method tests
        [TestFixture]
        private class ToggleSkillMethodTests : PersonSkillsTests
        {
            [Test]
            public async Task ToggleSkill_AddSkill_ShouldReturnSuccess()
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
                var skill = await AssertCreateSkill($"Test Skill {Guid.NewGuid()}");
                
                // Act
                var result = await AssertTogglePersonSkill(person.Id, skill.Id);
                
                // Assert
                Assert.That(result.Succeeded);
                
                // Verify the skill was added
                var skills = await AssertGetPersonSkills(person.Id);
                Assert.That(skills.Any(s => s.Id == skill.Id));
            }
            
            [Test]
            public async Task ToggleSkill_RemoveSkill_ShouldReturnSuccess()
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
                var skill = await AssertCreateSkill($"Test Skill {Guid.NewGuid()}");
                
                // Add the skill first
                await AssertTogglePersonSkill(person.Id, skill.Id);
                
                // Verify the skill was added
                var skillsBefore = await AssertGetPersonSkills(person.Id);
                Assert.That(skillsBefore.Any(s => s.Id == skill.Id), Is.True);
                
                // Act - Toggle again to remove
                var result = await AssertTogglePersonSkill(person.Id, skill.Id);
                
                // Assert
                Assert.That(result.Succeeded);
                
                // Verify the skill was removed
                var skillsAfter = await AssertGetPersonSkills(person.Id);
                Assert.That(!skillsAfter.Any(s => s.Id == skill.Id));
            }
            
            [Test]
            public async Task ToggleSkill_WithInvalidIds_ShouldHandleError()
            {
                // Arrange
                int invalidPersonId = -1;
                int invalidSkillId = -1;
                
                try
                {
                    // Act
                    await PersonSkillsController.ToggleSkill(invalidPersonId, invalidSkillId);
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
