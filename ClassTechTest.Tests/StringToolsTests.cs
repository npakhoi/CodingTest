namespace ClassTechTest.Tests
{
    using Xunit;

    public class StringToolsTests
    {
        private readonly StringTools _stringTools;

        #region String Tool Tests

        public StringToolsTests()
        {
            _stringTools = new StringTools();
        }

        [Theory]
        [InlineData("ABCBA", "B")]
        [InlineData("ABCABA", "A")]
        [InlineData("AACBA", "A")]
        [InlineData("AaCB", "A")]
        [InlineData("ABCDEFG", null)]
        [InlineData("B", null)]
        [InlineData("", null)]
        [InlineData(null, null)]
        public void TestFindFirstDuplicatedCharacter(string input, string expected)
        {
            var actual = _stringTools.FindFirstDuplicatedCharacter(input);

            Assert.Equal(expected, actual);
        }

        #endregion

        #region Palindrome Tests

        [Theory]
        [InlineData("palindrome", false)]
        [InlineData("civic", true)]
        [InlineData("CIVIC", true)]
        [InlineData("CIVic", true)]
        [InlineData("", false)]
        [InlineData("  ", false)]
        [InlineData(null, false)]
        [InlineData("A", true)]
        public void TestIsPalindrome(string input, bool expected)
        {
            var actual = _stringTools.IsPalindrome(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Hello I am civic ana", " civic ")]
        [InlineData("Hello I am Anna", "Anna")]
        [InlineData("ghuewidhebdbobdsgyeb", "dbobd")]
        [InlineData("A", "A")]
        [InlineData("AB", null)]
        public void TestFindLargestPalindrome(string input, string expected)
        {
            var actual = _stringTools.FindLargestPalindrome(input);

            Assert.Equal(expected, actual);
        }

        #endregion
    }
}
