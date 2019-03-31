using DivisionGame;
using Xunit;

namespace DivisionGameTests
{
    [Trait("FizzBuzzer", "")]
    public class FizzBuzzerTests
    {
        [Theory(DisplayName =
                    "When number is divisible by neither 3 nor 5 " +
                    "then it is returned as string")]
        [InlineData(1, "1")]
        [InlineData(4, "4")]
        [InlineData(22, "22")]
        public void NumberDivisibleByNeither3Nor5ReturnsItAsString(int number, string expected)
        {
            var sut = new FizzBuzzer();

            Assert.Equal(expected, sut.Process(number));
        }

        [Theory(DisplayName =
                    "When number is divisible by 3 " +
                    "then Fizz is returned")]
        [InlineData(3)]
        [InlineData(9)]
        [InlineData(12)]
        public void NumberDivisibleBy3ReturnsFizz(int number)
        {
            var sut = new FizzBuzzer();

            Assert.Equal("Fizz", sut.Process(number));
        }

        [Theory(DisplayName =
                    "When number is divisible by 5 " +
                    "then Buzz is returned")]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void NumberDivisibleBy5ReturnsBuzz(int number)
        {
            var sut = new FizzBuzzer();

            Assert.Equal("Buzz", sut.Process(number));
        }

        [Theory(DisplayName =
                    "When number is divisible by both 3 and 5 " +
                    "then FizzBuzz is returned")]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void NumberDivisibleByBoth3And5ReturnsFizzBuzz(int number)
        {
            var sut = new FizzBuzzer();

            Assert.Equal("FizzBuzz", sut.Process(number));
        }
    }
}