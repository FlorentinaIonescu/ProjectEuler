using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem23
    {
        // Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.

        public static void Run()
        {
            int limit = 28123;
            bool[] isAbundant = new bool[limit + 1]; //create an array of booleans to store whether each number up to the limit is abundant or not

            
            for (int i = 1; i <= limit; i++)
            {
                isAbundant[i] = IsAbundant(i);
            }

            // looping through all numbers from 1 up to the limit to check whether each of them can be written as the sum of two abundant numbers
            long sum = 0;
            for (int i = 1; i <= limit; i++)
            {
                bool canBeWrittenAsSumOfAbundant = false;
                for (int j = 1; j <= i / 2; j++)
                {
                    if (isAbundant[j] && isAbundant[i - j])
                    {
                        canBeWrittenAsSumOfAbundant = true;
                        break;
                    }
                }
                // means that the current number cannot be written as the sum of two abundant numbers, so we add it to the sum.
                if (!canBeWrittenAsSumOfAbundant)
                {
                    sum += i;
                }
            }

            Console.WriteLine("The sum of all the positive integers which cannot be written as the sum of two abundant numbers is: " + sum);
            Console.ReadLine();
        }

        static bool IsAbundant(int n) // for filling the array
        {
            int sumOfDivisors = 1;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    sumOfDivisors += i;
                    if (i != n / i)
                    {
                        sumOfDivisors += n / i;
                    }
                }
            }
            return sumOfDivisors > n;
        }
    }
}