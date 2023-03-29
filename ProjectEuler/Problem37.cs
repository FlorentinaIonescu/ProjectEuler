using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem37
    {
        // The number 3797 has an interesting property.Being prime itself, it is possible to continuously remove digits from left to right, and remain prime at each stage: 3797, 797, 97, and 7. Similarly we can work from right to left: 3797, 379, 37, and 3.
        // Find the sum of the only eleven primes that are both truncatable from left to right and right to left.
        // NOTE: 2, 3, 5, and 7 are not considered to be truncatable primes.

        // takes an integer as input and returns true if the number is prime, and false otherwise
        static bool IsPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        // takes an integer as input and returns true if the number is a truncatable prime, and false otherwise
        static bool IsTruncatablePrime(int n)
        {
            int temp = n;

            // Check if all left-truncations are prime
            while (temp > 0)
            {
                if (!IsPrime(temp))
                {
                    return false;
                }

                temp /= 10;
            }

            // Check if all right-truncations are prime
            int div = 10;
            while (n % div != n)
            {
                if (!IsPrime(n % div))
                {
                    return false;
                }

                div *= 10;
            }

            return true;
        }

        // finds the first 11 truncatable primes and adds them together to get the solution to the problem
        public static void Run()
        {
            int count = 0;
            int sum = 0;
            int i = 11;

            while (count < 11)
            {
                if (IsTruncatablePrime(i))
                {
                    count++;
                    sum += i;
                }

                i++;
            }

            Console.WriteLine("The sum of the 11 truncatable primes is: " + sum);
            Console.ReadLine();
        }
    }
}