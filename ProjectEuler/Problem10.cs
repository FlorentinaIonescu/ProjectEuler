using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem10
    {
        // The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
        // Find the sum of all the primes below two million.

        static void Main(string[] args)
        {
            long limit = 2000000;
            long sum = 0;

            bool[] primes = new bool[limit + 1];

            for (long i = 2; i <= limit; i++)
            {
                primes[i] = true;
            }

            for (long i = 2; i * i <= limit; i++)
            {
                if (primes[i])
                {
                    for (long j = i * i; j <= limit; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }

            for (long i = 2; i <= limit; i++)
            {
                if (primes[i])
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }

    }
}