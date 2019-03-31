using DivisionGame;
using Xunit;

namespace DivisionGameTests
{
    [Trait("FuzzJazzer", "")]
    public class FuzzJazzerTests
    {
        [Theory(DisplayName =
                    "When the number is divisible by neither 4 nor 9 " +
                    "then it is returned as string")]
        [InlineData(1, "1")]
        [InlineData(4, "4")]
        [InlineData(22, "22")]
        public void NumberDivisibleByNeither4Nor9ReturnsItAsString(int number, string expected)
        {
            var sut = new FizzBuzzer();

            Assert.Equal(expected, sut.Process(number));
        }

        [Theory(DisplayName =
                    "When the number is divisible by 4 " +
                    "then Fuzz is returned")]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(12)]
        public void NumberDivisibleBy4ReturnsFuzz(int number)
        {
            Assert.Equal("Fuzz", CreateSut().Process(number));
        }

        [Theory(DisplayName =
                    "When the number is divisible by 9 " +
                    "then Jazz is returned")]
        [InlineData(9)]
        [InlineData(18)]
        [InlineData(27)]
        public void NumberDivisibleBy9ReturnsJazz(int number)
        {
            Assert.Equal("Jazz", CreateSut().Process(number));
        }

        [Theory(DisplayName =
                    "When the number is divisible by both 4 and 9 " +
                    "then FuzzJazz is returned")]
        [InlineData(36)]
        [InlineData(72)]
        public void NumberDivisibleByBoth4And9ReturnsFuzzJazz(int number)
        {
            Assert.Equal("FuzzJazz", CreateSut().Process(number));
        }

        private static FuzzJazzer CreateSut()
        {
            return new FuzzJazzer();
        }
    }
}