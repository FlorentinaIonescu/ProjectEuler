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
    public static class Problem20
    {
        // Find the sum of the digits in the number 100!

        public static void Run()
        {
            BigInteger factorial = 1;
            // multiplying each number from 1 to 100 together
            for (int i = 1; i <= 100; i++)
            {
                factorial *= i;
            }

            // iterate over each digit
            int digitSum = 0;
            foreach (char digit in factorial.ToString())
            {
                digitSum += int.Parse(digit.ToString());
            }

            Console.WriteLine("The sum of the digits in 100! is: " + digitSum);
            Console.ReadLine();
        }
    }
}