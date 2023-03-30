using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem47
    {
        // Find the first four consecutive integers to have four distinct prime factors each. What is the first of these numbers?

        // this program may take some time to run, since it involves checking a large number of integers
        public static void Run()
        {
            int targetDistinctFactors = 4; // target number of distinct factors 
            int consecutiveNumbers = 4; // number of consecutive numbers to look for

            int i = 1;
            // iterate over all integers starting from 1
            while (true)
            {
                bool found = true;
                for (int j = i; j < i + consecutiveNumbers; j++)
                {
                    if (GetDistinctPrimeFactors(j) != targetDistinctFactors)
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                {
                    Console.WriteLine(i);
                    break;
                }

                i++;
            }
            Console.ReadLine();
        }

        // counts the number of distinct prime factors of an integer by dividing out each factor as many times as possible
        static int GetDistinctPrimeFactors(int n)
        {
            int count = 0;
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                    while (n % i == 0)
                    {
                        n /= i;
                    }
                }
            }

            return count;
        }
    }
}