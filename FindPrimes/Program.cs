using System;
using System.Collections.Generic;

namespace FindPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Finder \n");
            int input = 0;
            while (input < 1 || input > 1000)
            {
                Console.WriteLine("Enter a value between 1 and 1000");
                input = Convert.ToInt32(Console.ReadLine());
            }
            int total = FindPrimes.TotalPrimesBeforeN(input);
            List<int> primes = FindPrimes.PrimesBeforeN(input);
            primes.Reverse();

            Console.WriteLine($"\nThere are {total} prime numbers before {input} \n");
            Console.WriteLine($"Primes before {input}");
            foreach (int value in primes)
            {
                Console.Write($"{value}, ");
            }
            Console.WriteLine("\n \n");
        }
    }
}
