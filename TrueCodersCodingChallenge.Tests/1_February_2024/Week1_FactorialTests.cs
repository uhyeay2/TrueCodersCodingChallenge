using TrueCodersCodingChallenge._1_February_2024;

namespace TrueCodersCodingChallenge.Tests._1_February_2024
{
    public class Week1_FactorialTests
    {
        private static readonly Week1_Factorial _factorial = new Week1_Factorial();

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-2)]
        [InlineData(-3)]
        [InlineData(-4)]
        [InlineData(-5)]
        [InlineData(-10)]
        [InlineData(-15)]
        [InlineData(-20)]
        public void Factorial_Given_InputIsLessThanOrEqualToZero_ShouldReturn_Zero(int input)
        {
            var expected = 0;

            var result = _factorial.Challenge(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Factorial_Given_InputIsOne_ShouldReturn_One()
        {
            var expected = 1;

            var input = 1;

            var result = _factorial.Challenge(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 2)]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        [InlineData(5, 120)]
        [InlineData(6, 720)]
        [InlineData(7, 5040)]
        [InlineData(8, 40320)]
        [InlineData(9, 362880)]
        [InlineData(10, 3628800)]
        public void Factorial_Given_InputGreaterThanOne_ShouldReturn_ProductOfAllPositiveNumbersLessThanInput(int input, int expected)
        {
            var result = _factorial.Challenge(input);

            Assert.Equal(expected, result);
        }
    }
}
