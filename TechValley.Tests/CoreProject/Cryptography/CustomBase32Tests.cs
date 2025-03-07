using NUnit.Framework;
using NUnit.Framework.Legacy;
using TechValley.Core.Cryptography;

namespace TechValley.Tests.CoreProject.Cryptography
{
    [TestFixture]
    public class CustomBase32Tests
    {
        [Test]
        public void ToBase32_ValidInput_ReturnsCorrectBase32()
        {
            // Arrange
            byte[] input = new byte[] { 0x01, 0x23, 0x45, 0x67, 0x89 };

            // Act
            string result = CustomBase32.ToBase32(input);

            // Assert
            ClassicAssert.AreEqual("AID3F6AEXG=", result);  // Expected Base32 output for the given input
        }

        [Test]
        public void ToBase32_EmptyInput_ReturnsEmptyString()
        {
            // Act
            string result = CustomBase32.ToBase32(new byte[0]);

            // Assert
            ClassicAssert.AreEqual("", result);  // Empty input should result in an empty string
        }

        [Test]
        public void ToBase32_NullInput_ThrowsArgumentNullException()
        {
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => CustomBase32.ToBase32(null));
        }

        [Test]
        public void FromBase32_ValidInput_ReturnsCorrectByteArray()
        {
            // Arrange
            string input = "AID3F6AEXG=";

            // Act
            byte[] result = CustomBase32.FromBase32(input);

            // Assert
            CollectionAssert.AreEqual(new byte[] { 0x01, 0x23, 0x45, 0x67, 0x89 }, result);
        }

        [Test]
        public void FromBase32_EmptyInput_ReturnsEmptyByteArray()
        {
            // Act
            byte[] result = CustomBase32.FromBase32("");

            // Assert
            CollectionAssert.AreEqual(new byte[0], result);  // Empty string should result in empty byte array
        }

        [Test]
        public void FromBase32_NullInput_ThrowsArgumentNullException()
        {
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => CustomBase32.FromBase32(null));
        }

        [Test]
        public void FromBase32_InvalidCharacters_ThrowsFormatException()
        {
            // Arrange
            string input = "AID3F6AEXG@";  // Invalid character (@)

            // Act & Assert
            Assert.Throws<FormatException>(() => CustomBase32.FromBase32(input));
        }

        [Test]
        public void FromBase32_InvalidLength_ThrowsFormatException()
        {
            // Arrange
            string input = "AID3F6";  // Invalid length

            // Act & Assert
            Assert.Throws<FormatException>(() => CustomBase32.FromBase32(input));
        }

        [Test]
        public void FromBase32_InputWithPadding_ReturnsCorrectByteArray()
        {
            // Arrange
            string input = "AID3F6AEXG===";  // Base32 input with excessive padding

            // Act
            byte[] result = CustomBase32.FromBase32(input);

            // Assert
            // The correct output byte array should be { 0x01, 0x23, 0x45, 0x67, 0x89 }
            CollectionAssert.AreEqual(new byte[] { 0x01, 0x23, 0x45, 0x67, 0x89 }, result);
        }
    }
}
