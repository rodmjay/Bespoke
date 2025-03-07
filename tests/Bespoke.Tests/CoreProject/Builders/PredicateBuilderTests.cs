using NUnit.Framework;
using NUnit.Framework.Legacy;
using Bespoke.Core.Builders;


namespace Bespoke.Tests.CoreProject.Builders
{
    [TestFixture]
    public class PredicateBuilderTests
    {
        [Test]
        public void True_ShouldReturnExpressionThatEvaluatesToTrue()
        {
            // Arrange
            var predicate = PredicateBuilder.True<int>();

            // Act
            var result = predicate.Compile()(5);

            // Assert
            Assert.That(result, Is.True, "Predicate should always return true.");
        }

        [Test]
        public void False_ShouldReturnExpressionThatEvaluatesToFalse()
        {
            // Arrange
            var predicate = PredicateBuilder.False<int>();

            // Act
            var result = predicate.Compile()(5);

            // Assert
            Assert.That(result, Is.False, "Predicate should always return false.");
        }

        [Test]
        public void Or_ShouldCombinePredicatesWithLogicalOr()
        {
            // Arrange
            var predicate1 = PredicateBuilder.False<int>();
            var predicate2 = PredicateBuilder.True<int>();

            // Act
            var combinedPredicate = predicate1.Or(predicate2);
            var result = combinedPredicate.Compile()(5);

            // Assert
            Assert.That(result, Is.True, "Logical OR should return true if one predicate is true.");
        }

        [Test]
        public void And_ShouldCombinePredicatesWithLogicalAnd()
        {
            // Arrange
            var predicate1 = PredicateBuilder.True<int>();
            var predicate2 = PredicateBuilder.True<int>();

            // Act
            var combinedPredicate = predicate1.And(predicate2);
            var result = combinedPredicate.Compile()(5);

            // Assert
            Assert.That(result, Is.True, "Logical AND should return true if both predicates are true.");
        }

        [Test]
        public void And_ShouldReturnFalseIfOnePredicateIsFalse()
        {
            // Arrange
            var predicate1 = PredicateBuilder.True<int>();
            var predicate2 = PredicateBuilder.False<int>();

            // Act
            var combinedPredicate = predicate1.And(predicate2);
            var result = combinedPredicate.Compile()(5);

            // Assert
            Assert.That(result, Is.False, "Logical AND should return false if one predicate is false.");
        }


        [Test]
        public void CombinedPredicates_ShouldFilterCollectionCorrectly()
        {
            // Arrange
            var data = new[] { 1, 2, 3, 4, 5 };
            var isEven = PredicateBuilder.True<int>().And(x => x % 2 == 0);
            var isGreaterThanThree = PredicateBuilder.True<int>().And(x => x > 3);

            // Combine predicates
            var combinedPredicate = isEven.And(isGreaterThanThree);

            // Act
            var result = data.AsQueryable().Where(combinedPredicate).ToArray();

            // Assert
            Assert.That(result, "Filtered collection should contain only even numbers greater than 3.", Is.EqualTo(new[] { 4 }));
        }
    }
}
