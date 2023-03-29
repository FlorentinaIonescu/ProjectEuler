using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem35
    {
        // The number, 197, is called a circular prime because all rotations of the digits: 197, 971, and 719, are themselves prime.
        // There are thirteen such primes below 100: 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, and 97.
        // How many circular primes are there below one million?

        // program uses the Sieve of Eratosthenes algorithm to generate all primes up to 1,000,000
        public static void Run()
        {
            int limit = 1000000;
            List<int> primes = GetPrimes(limit);

            int count = 0;
            foreach (int prime in primes)
            {
                if (IsCircularPrime(prime, primes))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }

        static List<int> GetPrimes(int limit)
        {
            bool[] sieve = new bool[limit + 1];
            for (int i = 2; i <= limit; i++)
            {
                sieve[i] = true;
            }

            for (int i = 2; i * i <= limit; i++)
            {
                if (sieve[i])
                {
                    for (int j = i * i; j <= limit; j += i)
                    {
                        sieve[j] = false;
                    }
                }
            }

            List<int> primes = new List<int>();
            for (int i = 2; i <= limit; i++)
            {
                if (sieve[i])
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        // checks if each prime is a circular prime (i.e., if all rotations of its digits are also prime)
        static bool IsCircularPrime(int prime, List<int> primes)
        {
            int n = prime;
            int digits = (int)Math.Log10(n) + 1;

            for (int i = 0; i < digits; i++)
            {
                if (!primes.Contains(n))
                {
                    return false;
                }

                int lastDigit = n % 10;
                n /= 10;
                n += lastDigit * (int)Math.Pow(10, digits - 1);
            }

            return true;
        }
    }
}