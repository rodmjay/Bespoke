using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using Bespoke.Data.Bases;
using Bespoke.Data.Enums;

namespace Bespoke.Tests.DataProject.Bases;

[TestFixture]
public class BaseEntityTests
{
    private class TestEntity : BaseEntity<TestEntity>
    {
        public int Id { get; set; }

        public override void Configure(EntityTypeBuilder<TestEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
        }
    }

    private EntityTypeBuilder<TestEntity> _mockBuilder;
    private Mock<IModel> _mockModel;

    [SetUp]
    public void Setup()
    {
        _mockModel = new Mock<IModel>();
        var modelBuilder = new ModelBuilder(new ConventionSet());
        _mockBuilder = modelBuilder.Entity<TestEntity>();
    }

    [Test]
    public void ObjectState_Should_SetAndGetCorrectly()
    {
        // Arrange
        var entity = new TestEntity
        {
            // Act
            ObjectState = ObjectState.Added
        };

        // Assert
        ClassicAssert.AreEqual(ObjectState.Added, entity.ObjectState);
    }
}