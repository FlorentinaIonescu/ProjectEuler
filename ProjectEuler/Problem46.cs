using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem46
    {
        // What is the smallest odd composite that cannot be written as the sum of a prime and twice a square?

        public static void Run()
        {
            int limit = 10000;
            bool[] isComposite = new bool[limit + 1]; //boolean array to keep track of which numbers are composite
            bool found = false;

            // Sieve of Eratosthenes
            for (int i = 2; i * i <= limit; i++)
            {
                if (!isComposite[i])
                {
                    for (int j = i * i; j <= limit; j += i)
                    {
                        isComposite[j] = true;
                    }
                }
            }

            // loop through all odd composite numbers from 9 up to the limit
            for (int n = 9; n <= limit; n += 2)
            {
                if (!isComposite[n])
                {
                    continue;
                }

                found = false;

                // Check if n can be written as the sum of a prime and twice a square
                for (int i = 1; 2 * i * i < n; i++)
                {
                    int diff = n - 2 * i * i;

                    if (!isComposite[diff / 2]) // we divide diff by 2 since we only need to check odd numbers for primality
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("The smallest odd composite that cannot be written as the sum of a prime and twice a square is {0}", n);
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}