﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using TechValley.Core.Settings;
using TechValley.Data;
using TechValley.Data.Enums;
using TechValley.Tests.Stubs;

namespace TechValley.Tests.DataProject.Bases;

public class BaseContextTests
{
    private readonly DbContextOptions<TestDbContext> _dbContextOptions = new DbContextOptionsBuilder<TestDbContext>()
        .UseInMemoryDatabase("TestDb")
        .Options;

    // Set up an in-memory database for testing

    [Test]
    public void SaveChanges_ShouldThrowDbUpdateException_WhenValidationFails()
    {
        var settings = Options.Create(new DbSettings());

        // Arrange
        var dbContext = new TestDbContext(_dbContextOptions, settings);

        // Mock entity that implements IValidatableObject and will fail validation
        var invalidEntity = new TestEntity()
        {
            Name = "invalid"
        };  // Make sure this fails validation

        dbContext.Add(invalidEntity);

        // Act & Assert
        var exception = Assert.Throws<DbUpdateException>(() => dbContext.SaveChanges());
        Assert.That(exception.Message, Does.Contain("Validation failed"));
    }

    [Test]
    public void SaveChanges_ShouldSaveEntities_WhenValid()
    {
        var appSettings = new AppSettings();
        var settings = Options.Create(new DbSettings());
        
        // Arrange
        var dbContext = new TestDbContext(_dbContextOptions, settings);
        var validEntity = new TestEntity()
        {
            Name = "Something",
            ObjectState = ObjectState.Added
        };  // Make sure this passes validation

        dbContext.Add(validEntity);

        // Act
        var result = dbContext.SaveChanges();

        // Assert
        ClassicAssert.AreEqual(1, result);  // Ensure one record is saved
    }

    [Test]
    public async Task SaveChangesAsync_ShouldSaveEntities_WhenValid()
    {
        var settings = Options.Create(new DbSettings());

        // Arrange
        var dbContext = new TestDbContext(_dbContextOptions, settings);
        var validEntity = new TestEntity()
        {
            ObjectState = ObjectState.Added,
            Name = "test"
        };  // Make sure this passes validation

        dbContext.Add(validEntity);

        // Act
        var result = await dbContext.SaveChangesAsync();

        // Assert
        ClassicAssert.AreEqual(1, result);  // Ensure one record is saved
    }
}