namespace CodingChallenges.Tests
{
    public class CodingChallengesTests
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 2, 5)]
        [InlineData(2, 2, 12)]
        public void SumOrTripleSumOf2Numbers(int a, int b, int expected)
        {
            Assert.Equal(expected, CodingChallenges.SumOrTripleSumOf2Numbers(a, b));
        }

        [Theory]
        [InlineData(53, 6)]
        [InlineData(30, 21)]
        [InlineData(51, 0)]
        public void AbsoluteDifference(int input, int expected)
        {
            Assert.Equal(expected, CodingChallenges.AbsoluteDifference(input));
        }

        [Theory]
        [InlineData(30, 0, true)]
        [InlineData(25, 5, true)]
        [InlineData(30, 20, true)]
        [InlineData(20, 25, false)]
        public void Is30OrSumsTo30(int a, int b, bool expected)
        {
            Assert.Equal(expected, CodingChallenges.Is30OrSumsTo30(a, b));
        }
    }
}