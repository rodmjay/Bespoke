using System.Linq.Expressions;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using Bespoke.Data.Extensions;

namespace Bespoke.Tests.DataProject.Extensions;

[TestFixture]
public class DbExtensionsTests
{
    [Test]
    public void BuildLikeExpression_SingleKeyword_BuildsCorrectExpression()
    {
        // Arrange
        var keywords = new[] { "test" };
        Expression<Func<DummyEntity, string>> action = x => x.Name;

        // Act
        var expression = DbExtensions.BuildLikeExpression(keywords, action);

        // Assert
        ClassicAssert.NotNull(expression);
        ClassicAssert.AreEqual("x => value(Microsoft.EntityFrameworkCore.DbFunctions).Like(x.Name, \"%test\")", expression.ToString());
    }

    [Test]
    public void BuildLikeExpression_MultipleKeywords_BuildsCorrectExpression()
    {
        // Arrange
        var keywords = new[] { "test", "example" };
        Expression<Func<DummyEntity, string>> action = x => x.Name;

        // Act
        var expression = DbExtensions.BuildLikeExpression(keywords, action);

        // Assert
        ClassicAssert.NotNull(expression);
        ClassicAssert.AreEqual("x => (value(Microsoft.EntityFrameworkCore.DbFunctions).Like(x.Name, \"%test\") OrElse value(Microsoft.EntityFrameworkCore.DbFunctions).Like(x.Name, \"%example\"))"
            , expression.ToString());
    }

    [Test]
    public void BuildLikeExpression_EmptyKeywords_ReturnsNullExpression()
    {
        // Arrange
        var keywords = Array.Empty<string>();
        Expression<Func<DummyEntity, string>> action = x => x.Name;

        // Assert
        Assert.Throws<ArgumentNullException>(() => DbExtensions.BuildLikeExpression(keywords, action).Compile());
    }
}

// A dummy entity class for testing
public class DummyEntity
{
    public string Name { get; set; }
}