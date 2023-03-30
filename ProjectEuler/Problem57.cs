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
    public static class Problem57
    {
        // In the first one-thousand expansions, how many fractions contain a numerator with more digits than the denominator?

        public static void Run()
        {
            BigInteger numerator = 3, denominator = 2;
            int count = 0;

            for (int i = 1; i <= 1000; i++)
            {
                // Add 2 to the denominator and swap the numerator and denominator
                denominator += numerator;
                numerator = denominator - numerator;
                denominator -= numerator;

                // Check if the numerator has more digits than the denominator
                if (numerator.ToString().Length > denominator.ToString().Length)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}