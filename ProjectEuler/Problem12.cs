using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem12
    {
        // ...What is the value of the first triangle number to have over five hundred divisors?

        static void Main(string[] args)
        {
            int n = 1;
            int triangularNumber = 0;
            int numDivisors = 0;

            while (numDivisors <= 500)
            {
                triangularNumber += n;
                numDivisors = GetNumDivisors(triangularNumber);
                n++;
            }

            Console.WriteLine("The first triangular number with over 500 divisors is: " + triangularNumber);
        }

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