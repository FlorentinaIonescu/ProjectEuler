using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem24
    {
        // What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?

        // this algorithm assumes that n is 1-based (i.e., the first permutation is numbered 1, not 0).
        // If n is 0-based, calculating index of the digit to select requires dividing 'n', instead of '(n - 1)', by the factorial
        public static void Run()
        {
            int n = 10; // the nth lexicographic permutation to find
            int[] digits = Enumerable.Range(0, 10).ToArray(); // array of digits to permute
            int[] result = new int[10]; // array to hold the result

            for (int i = 0; i < 10; i++)
            {
                int factorial = Factorial(9 - i);
                int index = (n - 1) / factorial;
                result[i] = digits[index];
                digits = digits.Where((value, idx) => idx != index).ToArray();
                n -= index * factorial;
            }

            Console.WriteLine(string.Join("", result));
            Console.ReadLine();
        }

        static int Factorial(int n)
        {
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}