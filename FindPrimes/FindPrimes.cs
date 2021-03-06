using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPrimes
{
    public class FindPrimes
    {
        /// <summary>
        /// Checks to see if a number is prime by dividing it by every value less than itself
        /// and checking for a remainder.
        /// </summary>
        /// <param name="n"> int n, the number to check </param>
        /// <returns> true : false </returns>
        public static bool IsPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Find the total number of prime numbers before a given value, not including the value.
        /// </summary>
        /// <param name="n"> int n </param>
        /// <returns> int total, total prime numbers </returns>
        public static int TotalPrimesBeforeN(int n)
        {
            int total = 0;
            for (int i = n-1; i > 1; i--)
            {
                if (IsPrime(i))
                {
                    total++;
                }
            }
            return total;
        }

        /// <summary>
        /// Create a list of all prime numbers before the given value.
        /// </summary>
        /// <param name="n"> int n </param>
        /// <returns> List<int> of prime numbers before n </int> </returns>
        public static List<int> PrimesBeforeN(int n)
        {
            List<int> primes = new();
            for (int i = n - 1; i > 1; i--)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
        }
    }

}
