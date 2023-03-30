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
    public static class Problem56
    {
        // A googol(10100) is a massive number: one followed by one-hundred zeros; 100100 is almost unimaginably large: one followed by two-hundred zeros.Despite their size, the sum of the digits in each number is only 1.
        // Considering natural numbers of the form, ab, where a, b< 100, what is the maximum digital sum?


        public static void Run()
        {
            int maxDigitalSum = 0;

            for (int a = 1; a < 100; a++)
            {
                for (int b = 1; b < 100; b++)
                {
                    BigInteger power = BigInteger.Pow(a, b);
                    int digitalSum = GetDigitalSum(power);

                    if (digitalSum > maxDigitalSum)
                    {
                        maxDigitalSum = digitalSum;
                    }
                }
            }

            Console.WriteLine("The maximum digital sum is " + maxDigitalSum);
            Console.ReadLine();
        }

        static int GetDigitalSum(BigInteger n)
        {
            int sum = 0;

            while (n > 0)
            {
                sum += (int)(n % 10);
                n /= 10;
            }

            return sum;
        }
    }
}