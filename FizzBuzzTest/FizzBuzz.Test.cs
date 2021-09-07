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
        public void FizzbuzzOf5MustBeBuzz()
        {
            Assert.Equal( "Buzz", _sut.FizzBuzz(5));
        }

        [Fact]
        public void FizzbuzzOf3MustBeFizz()
        {
            Assert.Equal("Fizz", _sut.FizzBuzz(3));
        }
        
        [Fact]
        public void FizzbuzzOf15MustBeFizzBuzz()
        {
            Assert.Equal("FizzBuzz", _sut.FizzBuzz(15));            
        }


        [Fact]
        public void FizzbuzzOf2MustBeStr2()
        {
            Assert.Equal("2", _sut.FizzBuzz(2));            
        }


        [Fact]
        public void FizzbuzzOf100MustBeBuzz()
        {
            Assert.Equal("Buzz", _sut.FizzBuzz(100));
        }


        [Fact]
        public void FizzbuzzOfAValueGratherThan100MustThrowError()
        {
          Assert.Throws<ArgumentException>( () => _sut.FizzBuzz(100 + 1 ) );
        }


    }
}
