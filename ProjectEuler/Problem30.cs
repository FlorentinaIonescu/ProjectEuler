using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem30
    {
        // Find the sum of all the numbers that can be written as the sum of fifth powers of their digits.

        public static void Run()
        {
            int sum = 0;
            // iterates through all numbers from 2 to 999,999 (since 1 is not included in the problem statement)
            // checks if the number is equal to the sum of its digits raised to the fifth power 
            for (int i = 2; i < 1000000; i++)
            {
                if (i == SumOfPowersOfDigits(i, 5))
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        // iteratively calculates the sum by extracting each digit of n, raising it to the p power, and adding it to sum
        static int SumOfPowersOfDigits(int n, int p)
        {
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                sum += (int)Math.Pow(digit, p);
                n /= 10;
            }
            return sum;
        }
    }
}