using System;
using Xunit;
using FindPrimes;

namespace FindPrimesTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, true)]
        [InlineData(17, true)]
        [InlineData(37, true)]
        [InlineData(53, true)]
        [InlineData(89, true)]
        [InlineData(0, false)]
        [InlineData(1, false)]
        [InlineData(16, false)]
        [InlineData(78, false)]
        [InlineData(99, false)]
        public void IsPrimeCanSuccessfullyCheckIfNumberIsPrime(int n, bool expected)
        {
            bool result = FindPrimes.FindPrimes.IsPrime(n);
            Assert.Equal(expected, result);
        }
    }
}
