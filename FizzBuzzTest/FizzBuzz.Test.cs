using System;
using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzTest
    {
        private readonly IFizzBuzz _sut = new DictionaryFizzBuzz();


        [Fact]
        public void FindTest()
        {
            _sut.FizzBuzz(1);
        }

        [Fact]
        public void FizzBuzzOfZeroMustThrowError()
        {
            Assert.Throws<ArgumentException>( () => _sut.FizzBuzz(0) );
        }

        [Fact]
        public void FizzBuzzOfA_ValueGratherThan100MustThrowError()
        {
          Assert.Throws<ArgumentException>( () => _sut.FizzBuzz(100 + 1 ) );
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(100, "Buzz")]
        public void FizzBuzzOfA_SetOfValuesMatches(sbyte inputValue, string output)
        {
          Assert.Equal(output, _sut.FizzBuzz(inputValue));
        }


    }
}
