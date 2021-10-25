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
    }
}
