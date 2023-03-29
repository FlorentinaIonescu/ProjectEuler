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

        // This program uses the Sieve of Eratosthenes algorithm to find all the prime numbers up to 2 million, and then adds up all the primes to get the answer to the problem.

        public static void Run()
        {
            long limit = 2000000; // The limit variable is set to 2 million, which is the upper bound for the primes we need to find
            long sum = 0; // used to accumulate the sum of all the primes

            // The primes array is initialized with true for all indices from 2 to limit, since we know that all integers greater than or equal to 2 are potentially prime
            bool[] primes = new bool[limit + 1];

            for (long i = 2; i <= limit; i++)
            {
                primes[i] = true;
            }

            // Since any multiple of i less than i * i will have already been marked as composite by a smaller prime factor, we can skip over them
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

            // adds up all the primes by iterating over the primes array and adding up the values that are still set to true
            for (long i = 2; i <= limit; i++)
            {
                if (primes[i])
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }

    }
}