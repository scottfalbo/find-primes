using System;
using Xunit;
using FindPrimes;
using System.Collections.Generic;

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

        [Theory]
        [InlineData(17, 6)]
        [InlineData(42, 13)]
        [InlineData(100, 25)]
        public void TotalPrimesBeforeNCanSuccessfullyReturnTotalNumberOfPrimes(int n, int expected)
        {
            int result = FindPrimes.FindPrimes.TotalPrimesBeforeN(n);
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(PrimeListData))]

        public void PrimesBeforeNCanSuccessfullyReturnAListOfPrimeValues(int n, List<int> expected)
        {
            List<int> result = FindPrimes.FindPrimes.PrimesBeforeN(n);
            result.Reverse();
            Assert.Equal(expected, result);
        }
        /// <summary>
        /// Helper object for PrimesBeforeN tests
        /// </summary>
        public static IEnumerable<object[]> PrimeListData =>
            new List<object[]>
            {
                        new object[] { 5, new List<int>() { 2, 3} },
                        new object[] { 12, new List<int>() { 2, 3, 5, 7, 11} },
                        new object[] { 100, new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23,
                            29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97} }
            };
    }
}
