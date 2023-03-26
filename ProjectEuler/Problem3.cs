using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem3
    {
        // The prime factors of 13195 are 5, 7, 13 and 29. What is the largest prime factor of the number 600851475143 ?

        public static void Run()
        {

            // Define the number to factor
            long number = 600851475143;

            // Find the largest prime factor
            long largestFactor = GetLargestPrimeFactor(number);

            // Output the result
            Console.WriteLine("The largest prime factor of 600851475143 is: " + largestFactor);
        }

        // Recursive function to find the largest prime factor of a number
        static long GetLargestPrimeFactor(long n)
        {
            for (long i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return Math.Max(i, GetLargestPrimeFactor(n / i));
                }
            }
            return n;
        }
    }

    // chatgpt
}