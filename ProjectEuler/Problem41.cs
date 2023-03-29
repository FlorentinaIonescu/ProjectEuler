using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem41
    {
        // We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once.For example, 2143 is a 4-digit pandigital and is also prime.
        // What is the largest n-digit pandigital prime that exists?

        // program generates all permutations of the digits 1 through 7 and checks if each permutation is prime
        public static void Run()
        {
            int[] digits = { 1, 2, 3, 4, 5, 6, 7 };
            int largestPandigitalPrime = 0;

            do
            {
                int n = digits.Length;
                int number = int.Parse(string.Join("", digits));

                if (IsPrime(number) && number > largestPandigitalPrime)
                {
                    largestPandigitalPrime = number;
                }

                // Generate the next permutation
                int i = n - 2;
                while (i >= 0 && digits[i] >= digits[i + 1])
                {
                    i--;
                }
                if (i >= 0)
                {
                    int j = n - 1;
                    while (digits[j] <= digits[i])
                    {
                        j--;
                    }
                    Swap(ref digits[i], ref digits[j]);
                }
                Array.Reverse(digits, i + 1, n - i - 1);
            } while (digits[0] == 1);

            Console.WriteLine(largestPandigitalPrime);
            Console.ReadLine();
        }

        // standard primality test using trial division up to the square root of the number being tested
        static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            else if (n <= 3)
            {
                return true;
            }
            else if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }
            int i = 5;
            while (i * i <= n)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
                i += 6;
            }
            return true;
        }

        // helper function for swapping the values of two integers
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}