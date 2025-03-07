using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using TechValley.Data.Enums;
using TechValley.Data.Helpers;

namespace TechValley.Tests.DataProject.Helpers
{
    [TestFixture]
    public class StateHelperTests
    {
        #region ConvertState(ObjectState)

        [Test]
        public void ConvertState_ShouldReturnEntityStateAdded_WhenStateIsAdded()
        {
            // Arrange
            var objectState = ObjectState.Added;

            // Act
            var result = StateHelper.ConvertState(objectState);

            // Assert
            ClassicAssert.AreEqual(EntityState.Added, result);
        }

        [Test]
        public void ConvertState_ShouldReturnEntityStateModified_WhenStateIsModified()
        {
            // Arrange
            var objectState = ObjectState.Modified;

            // Act
            var result = StateHelper.ConvertState(objectState);

            // Assert
            ClassicAssert.AreEqual(EntityState.Modified, result);
        }

        [Test]
        public void ConvertState_ShouldReturnEntityStateDeleted_WhenStateIsDeleted()
        {
            // Arrange
            var objectState = ObjectState.Deleted;

            // Act
            var result = StateHelper.ConvertState(objectState);

            // Assert
            ClassicAssert.AreEqual(EntityState.Deleted, result);
        }

        [Test]
        public void ConvertState_ShouldReturnEntityStateUnchanged_WhenStateIsUnchanged()
        {
            // Arrange
            var objectState = ObjectState.Unchanged;

            // Act
            var result = StateHelper.ConvertState(objectState);

            // Assert
            ClassicAssert.AreEqual(EntityState.Unchanged, result);
        }

        //[Test]
        //public void ConvertState_ShouldThrowArgumentOutOfRangeException_WhenStateIsUnknown()
        //{
        //    // Arrange
        //    var objectState = (ObjectState)999;

        //    // Act & Assert
        //    var ex = Assert.Throws<ArgumentOutOfRangeException>(() => StateHelper.ConvertState(objectState));
        //    ClassicAssert.That(ex.ParamName, Is.EqualTo("state"));
        //}

        #endregion

        #region ConvertState(EntityState)

        [Test]
        public void ConvertState_ShouldReturnObjectStateUnchanged_WhenStateIsDetached()
        {
            // Arrange
            var entityState = EntityState.Detached;

            // Act
            var result = StateHelper.ConvertState(entityState);

            // Assert
            ClassicAssert.AreEqual(ObjectState.Unchanged, result);
        }

        [Test]
        public void ConvertState_ShouldReturnObjectStateUnchanged_WhenStateIsUnchanged()
        {
            // Arrange
            var entityState = EntityState.Unchanged;

            // Act
            var result = StateHelper.ConvertState(entityState);

            // Assert
            ClassicAssert.AreEqual(ObjectState.Unchanged, result);
        }

        [Test]
        public void ConvertState_ShouldReturnObjectStateAdded_WhenStateIsAdded()
        {
            // Arrange
            var entityState = EntityState.Added;

            // Act
            var result = StateHelper.ConvertState(entityState);

            // Assert
            ClassicAssert.AreEqual(ObjectState.Added, result);
        }

        [Test]
        public void ConvertState_ShouldReturnObjectStateDeleted_WhenStateIsDeleted()
        {
            // Arrange
            var entityState = EntityState.Deleted;

            // Act
            var result = StateHelper.ConvertState(entityState);

            // Assert
            ClassicAssert.AreEqual(ObjectState.Deleted, result);
        }

        [Test]
        public void ConvertState_ShouldReturnObjectStateModified_WhenStateIsModified()
        {
            // Arrange
            var entityState = EntityState.Modified;

            // Act
            var result = StateHelper.ConvertState(entityState);

            // Assert
            ClassicAssert.AreEqual(ObjectState.Modified, result);
        }

        [Test]
        public void ConvertState_ShouldThrowArgumentOutOfRangeException_WhenStateIsUnknown()
        {
            // Arrange
            var entityState = (EntityState)999;

            // Act & Assert
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => StateHelper.ConvertState(entityState));
            Assert.That(ex.ParamName, Is.EqualTo("state"));
        }

        #endregion
    }
}
