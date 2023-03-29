using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem45
    {
        // Find the next triangle number that is also pentagonal and hexagonal.

        // program uses three variables n, t, and p to keep track of the indices of the hexagonal, triangular, and pentagonal numbers respectively
        // it then uses the formulas for computing the n-th hexagonal, triangular, and pentagonal numbers to generate the corresponding values
        public static void Run()
        {
            long n = 143; // Start with the first value of n that satisfies the condition
            long t = 285; // Start with the first value of t that satisfies the condition
            long p = 165; // Start with the first value of p that satisfies the condition

            long tn = t * (t + 1) / 2; // Compute the first triangular number
            long pn = p * (3 * p - 1) / 2; // Compute the first pentagonal number

            while (true)
            {
                if (tn == pn && tn > 40755) // Check if the numbers are equal and greater than 40755
                {
                    Console.WriteLine(tn);
                    break;
                }
                else if (tn <= pn) // If the triangular number is smaller, increment t
                {
                    t++;
                    tn = t * (t + 1) / 2;
                }
                else // If the pentagonal number is smaller, increment p
                {
                    p++;
                    pn = p * (3 * p - 1) / 2;
                }

                if (n * (2 * n - 1) == tn) // Check if the triangular number is also a hexagonal number
                {
                    n++;
                }
            }
            Console.ReadLine();
        }
    }
}