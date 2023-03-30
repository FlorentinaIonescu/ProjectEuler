using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem53
    {
        // [Combinatoric selections]

        public static void Run()
        {
            int count = 0;
            // iterates through all values of n and r, where n ranges from 1 to 100 and r ranges from 0 to n
            for (int n = 1; n <= 100; n++)
            {
                for (int r = 0; r <= n; r++)
                {
                    long value = Combination(n, r);
                    if (value > 1000000)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count); //outputs number of combinations that have a value greater than 1,000,000
            Console.ReadLine();
        }

        // checks for edge cases where r is equal to 0 or n, and returns 1 in those cases
        // calculates the numerator and denominator of the combination function using a loop and returns the result of the division of the numerator by the denominator
        static long Combination(int n, int r)
        {
            if (r == 0 || n == r)
            {
                return 1; // the combination function should evaluate to 1 instead of collapsing into 0
            }
            long numerator = 1;
            long denominator = 1;
            for (int i = 0; i < r; i++)
            {
                numerator *= n - i;
                denominator *= i + 1;
            }
            if (denominator == 0)
            {
                return 1;
            }
            return numerator / denominator;
        }
    }
}