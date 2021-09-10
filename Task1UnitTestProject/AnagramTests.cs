using Xunit;
using AnagramProject;

namespace Task1UnitTestProject
{
    public class AnagramTests
    {
        [Fact]
        public void Reverse_ModifiesTestString()
        {
            // Arrange
            var anagram = new Anagram();

            // Act
            var actual = anagram.Reverse("  a1bcd    efg!h");

            // Assert
            Assert.NotNull(actual);
            Assert.Equal("  d1cba    hgf!e", actual);
        }

        [Fact]
        public void Reverse_GetsNullOnInput()
        {
            // Arrange
            var anagram = new Anagram();

            // Act
            var actual = anagram.Reverse(null);

            // Assert
            Assert.NotNull(actual);
            Assert.Equal("", actual);
        }
    }
}
