using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem12
    {
        // ...What is the value of the first triangle number to have over five hundred divisors?

        public static void Run()
        {
            int n = 1;
            BigInteger triangularNumber = 0;
            int numDivisors = 0;

            // loop continues until we find a triangular number with over 500 divisors
            while (numDivisors <= 500)
            {
                // we calculate the next triangular number by adding n to triangularNumber,
                // and then we calculate the number of divisors of that triangular number using the GetNumDivisors function.
                // If the number of divisors is less than or equal to 500, we increment n and repeat the process.
                // If the number of divisors is greater than 500, we exit the loop and print out the first triangular number with over 500 divisors.
                triangularNumber += n;
                numDivisors = GetNumDivisors((int)triangularNumber);
                n++;
            }

            Console.WriteLine("The first triangular number with over 500 divisors is: " + triangularNumber);
            Console.ReadLine();
        }

        // calculates the number of divisors of a given number n by iterating from 1 to the square root of n and checking if n is divisible by each number
        // If it is, we add 2 to the count of divisors (since n/i is also a divisor), except when i is equal to the square root of n, in which case we only add 1 to the count of divisors
        static int GetNumDivisors(int n)
        {
            int numDivisors = 0;

            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    numDivisors += 2;
                }
            }

            if (Math.Sqrt(n) * Math.Sqrt(n) == n)
            {
                numDivisors--;
            }

            return numDivisors;
        }
    }
}