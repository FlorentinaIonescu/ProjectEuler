using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem34
    {
        // 145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.
        // Find the sum of all numbers which are equal to the sum of the factorial of their digits.
        // Note: As 1! = 1 and 2! = 2 are not sums they are not included.

        public static void Run()
        {
            int[] factorial = new int[10];
            // precomputes an array of factorials of digits from 0 to 9
            for (int i = 0; i < 10; i++)
            {
                factorial[i] = Factorial(i);
            }

            int sum = 0;
            // loops through all numbers from 10 to 99999
            for (int i = 10; i < 100000; i++)
            {
                int digitSum = DigitFactorialSum(i, factorial);
                // If the sum is equal to the number itself, then the number is added to the sum variable
                if (i == digitSum)
                {
                    sum += i;
                }
            }

            Console.WriteLine("The sum of all numbers which are equal to the sum of the factorial of their digits is: " + sum);
            Console.ReadLine();
        }

        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        // calculates the sum of the factorials of its digits 
        static int DigitFactorialSum(int n, int[] factorial)
        {
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                sum += factorial[digit];
                n /= 10;
            }
            return sum;
        }
    }
}