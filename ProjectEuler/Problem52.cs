using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem52
    {
        // It can be seen that the number, 125874, and its double, 251748, contain exactly the same digits, but in a different order.
        // Find the smallest positive integer, x, such that 2x, 3x, 4x, 5x, and 6x, contain the same digits.

        public static void Run()
        {
            int n = 1;
            // increment n until it finds the smallest positive integer that is a permutation of all its multiples from 2 to 6
            while (true)
            {
                if (IsPermutation(n, 2 * n) && IsPermutation(n, 3 * n)
                    && IsPermutation(n, 4 * n) && IsPermutation(n, 5 * n)
                    && IsPermutation(n, 6 * n))
                {
                    Console.WriteLine(n);
                    Console.ReadLine();
                    break;
                }
                n++;
            }
        }

        // checks if two numbers are permutations of each other by converting them into arrays of digits, sorting the arrays, and comparing each corresponding digit
        static bool IsPermutation(int a, int b)
        {
            int[] digitsA = GetDigits(a);
            int[] digitsB = GetDigits(b);

            Array.Sort(digitsA);
            Array.Sort(digitsB);

            for (int i = 0; i < digitsA.Length; i++)
            {
                if (digitsA[i] != digitsB[i])
                {
                    return false;
                }
            }

            return true;
        }

        // converts an integer into an array of its digits
        static int[] GetDigits(int number)
        {
            int[] digits = new int[(int)Math.Log10(number) + 1];

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                digits[i] = number % 10;
                number /= 10;
            }

            return digits;
        }

    }
}