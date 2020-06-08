using System;
using Xunit;
using FizzBuzz; 

namespace FizzBuzz.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ReturnsInputAsString()
        {
            Assert.Equal("1", FizzBuzz.FromIndex(1));
            Assert.Equal("16", FizzBuzz.FromIndex(16));
        }

        [Fact]
        public void ReturnsFizzOnThrees()
        {
            Assert.Equal("Fizz", FizzBuzz.FromIndex(3));
            Assert.Equal("Fizz", FizzBuzz.FromIndex(6));
        }

        [Fact]
        public void ReturnsBuzzOnFives()
        {
            Assert.Equal("Buzz", FizzBuzz.FromIndex(5));
            Assert.Equal("Buzz", FizzBuzz.FromIndex(10));
        }

        [Fact]
        public void ReturnsFizzBuzzOnFifteens()
        {
            Assert.Equal("FizzBuzz", FizzBuzz.FromIndex(15));
            Assert.Equal("FizzBuzz", FizzBuzz.FromIndex(30));
        }

        [Fact]
        public void PlaysUntilFifteen()
        {
            Assert.Equal("1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz", FizzBuzz.PlayTo(15));
        }
    }
}
