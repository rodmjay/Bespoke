using NUnit.Framework;
using Bespoke.Users.Validators;
using Bespoke.Users.Entities;
using Microsoft.AspNetCore.Identity;
using Moq;
using System;
using System.Threading.Tasks;

namespace Bespoke.Users.Tests.Validators
{
    [TestFixture]
    public class DuplicateEmailValidatorTests
    {
        private Mock<IUserEmailStore<User>> _mockUserEmailStore;

        [SetUp]
        public void Setup()
        {
            _mockUserEmailStore = new Mock<IUserEmailStore<User>>();
        }

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
}
