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
			Assert.Equal("1", FizzBuzz.FizzBuzzFromIndex(1));
        }
    }
}
