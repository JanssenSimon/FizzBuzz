using System;
using Xunit;
using FizzBuzz; 

namespace FizzBuzz.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ReturnInputAsString()
        {
            Assert.Equal("1", FizzBuzz.FromIndex(1));
        }

        [Fact]
        public void ReturnFizzOnThrees()
        {
            Assert.Equal("Fizz", FizzBuzz.FromIndex(3));
            Assert.Equal("Fizz", FizzBuzz.FromIndex(6));
        }
    }
}
