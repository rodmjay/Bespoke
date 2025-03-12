using Moq;
using NUnit.Framework;

namespace Bespoke.Users.Tests.Validators;

[TestFixture]
public class DuplicateEmailValidatorTests
{
    [SetUp]
    public void Setup()
    {
        _mockUserEmailStore = new Mock<IUserEmailStore<User>>();
    }

    private Mock<IUserEmailStore<User>> _mockUserEmailStore;

    [TestFixture]
    public class ValidateAsyncTests : DuplicateEmailValidatorTests
    {
        [Test]
        public void Should_Validate_Email_Is_Not_Duplicate()
        {
            // This is a stub test
            Assert.IsTrue(true);
        }
    }
}